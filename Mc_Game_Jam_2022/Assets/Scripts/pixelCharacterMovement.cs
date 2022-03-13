using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(BoxCollider2D))]
public class pixelCharacterMovement : MonoBehaviour
{
    public float moveSpeed;
    private Animator anim;
    private bool playerMoving;
    public Vector2 lastMove;
    private Rigidbody2D player;
    private static bool playerExists;

    void Start()
    {
        anim = GetComponent<Animator>();
        player = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        playerMoving = false;
        float xAxis = Input.GetAxisRaw("Horizontal");
        float yAxis = Input.GetAxisRaw("Vertical");
        player.velocity = new Vector2(xAxis * moveSpeed, yAxis * moveSpeed);

        if (xAxis != 0f)
        {
            lastMove = new Vector2(xAxis, 0f);
            playerMoving = true;
        }
        if (yAxis != 0f)
        {
            lastMove = new Vector2(0f, yAxis);
            playerMoving = true;
        }

        anim.SetFloat("MoveX", xAxis);
        anim.SetFloat("MoveY", yAxis);
        anim.SetBool("Player Moving", playerMoving);
        //anim.SetFloat("Last Move X", lastMove.x);
        //anim.SetFloat("Last Move Y", lastMove.y);
    }
}

