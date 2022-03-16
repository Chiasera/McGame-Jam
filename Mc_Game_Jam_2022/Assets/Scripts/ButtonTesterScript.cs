using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTesterScript : MonoBehaviour
{

    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        animator.SetBool("IsNear", true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        animator.SetBool("IsNear", false);
    }

}
