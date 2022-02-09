using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChanMove : MonoBehaviour
{
    public Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>(); 
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            anim.SetTrigger("run");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            anim.SetTrigger("slide");
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            anim.SetTrigger("jump");
        }
    }
}
