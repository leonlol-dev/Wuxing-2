using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    public bool activated = false;

    public Animator animator;

    private void Start()
    {
        animator.SetBool("plateup", true);
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<rock>() )
        {
            activated = true;
            animator.SetBool("plateup", false);
        }

    
    }

    private void OnCollisionExit(Collision collision)
    {
        //activated = false;
        //animator.SetBool("plateup", true);
    }
}
