using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBallColour : MonoBehaviour
{
    public Rigidbody rbody;
    public float force = 1f;
    private Renderer rend;

    void Start()
    {
        rbody = GetComponent<Rigidbody>();
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        float inputx = Input.GetAxis("Horizontal");
        float inputz = Input.GetAxis("Vertical");

        float movex = inputx * force;
        float movez = inputz * force;

        rbody.AddForce(movex, 0f, movez);
    }

    void OnCollisionEnter(Collision col) 
    {
        if(col.collider.name == "Slab 1")
        {
            rend.material.color = Color.blue;
        }
        if (col.collider.name == "Slab 2")
        {
            rend.material.color = Color.red;
        }
        if (col.collider.name == "Slab 3")
        {
            rend.material.color = Color.yellow;
        }
        if (col.collider.name == "Slab 4")
        {
            rend.material.color = Color.white;
        }
        if (col.collider.name == "Slab 5")
        {
            rend.material.color = Color.black;
        }
        if (col.collider.name == "Cube 2")
        {
            rend.material.color = Color.magenta;
        }
        if (col.collider.name == "Cube 4")
        {
            rend.material.color = Color.green;
        }
    }
}
