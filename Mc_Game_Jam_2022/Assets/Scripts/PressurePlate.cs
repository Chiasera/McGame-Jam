using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    private Animator animator;
    private bool isPressed = false;
    public bool isMain;

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
        animator.SetBool("Touched", true);
        if(isPressed != true && isMain) {
            FindObjectOfType<DialogueTrigger>().TriggerDialogue();
        }
        if(isPressed != true && !isMain)
        {
            FindObjectOfType<Congrats>().letsGetIt();
        }
        isPressed = true;
    }
}
