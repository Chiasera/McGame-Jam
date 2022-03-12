using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(BoxCollider2D))]
public class pixelCharacterMovement : MonoBehaviour
{

    private BoxCollider2D boxCollider;
    private Animator animator;

    public float moveSpeed;
    
    private void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        if (x > 0.5f || x < -0.5f)
        {
            transform.Translate(new Vector3(x * moveSpeed * Time.deltaTime, 0f, 0f));
        }

        if (y > 0.5f || y < -0.5f)
        {
            transform.Translate(new Vector3(0f, y * moveSpeed * Time.deltaTime, 0f));
        }

        animator.SetFloat("MoveX", Input.GetAxisRaw("Horizontal"));
        animator.SetFloat("MoveY", Input.GetAxisRaw("Vertical"));
    }
}
