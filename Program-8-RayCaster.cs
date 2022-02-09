using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCaster : MonoBehaviour
{
    public float rotationSpeed = 20f;
    public Vector3 horizontalMovement;
   
    void Update()
    {
        horizontalMovement = new Vector3(0f, 0f, -Input.GetAxis("Horizontal"));
        transform.Rotate(horizontalMovement * rotationSpeed * Time.deltaTime);
        if(Input.GetKey(KeyCode.Space))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector2.up) * 10f, Color.magenta);
            RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.TransformDirection(Vector2.up), 10f);
            if (hit)
            {
                hit.transform.GetComponent<SpriteRenderer>().color= Color.magenta;
            }
        }
    }
}