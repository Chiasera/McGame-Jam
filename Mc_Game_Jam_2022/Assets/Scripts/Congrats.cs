using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Congrats : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }


    public void letsGetIt()
    {
        animator.SetBool("yes", true);
    }        
}
