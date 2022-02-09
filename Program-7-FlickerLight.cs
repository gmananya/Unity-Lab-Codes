using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickerLight : MonoBehaviour
{
    public Light lit;

    void Start()
    {
        lit = GetComponent<Light>();
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Color c = new Color();
            c.r = 1f;
            c.a = 1f;
            lit.color = c;
        }
        if (Input.GetMouseButtonDown(1))
        {
            Color c = new Color();
            c.g = 1f;
            c.a = 1f;
            lit.color = c;
        }
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            Color c = new Color();
            c.b = 1f;
            c.a = 1f;
            lit.color = c;
        }
    }
}
