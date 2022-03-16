using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrboText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        FindObjectOfType<DialogueTrigger>().TriggerDialogue();       
    }
}