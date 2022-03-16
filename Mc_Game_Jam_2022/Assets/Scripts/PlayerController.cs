using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5;
    public float h;
    private float v;
    private Animator animator;
    private Rigidbody2D rb;
    private bool isFacingLeft;
    private bool jumpKeyPressed;
    private bool frozen;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FreezeEnterScene());
        animator = this.GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        isFacingLeft = true;
    }

    // Update is called once per frame
    void Update()
    {
        jumpKeyPressed = Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.Space);
        animator.SetFloat("speed", Mathf.Abs(h));
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        if (frozen)
        {
            h = 0;
            v = 0;
        } 

        if (h<0 && !isFacingLeft)
        {
            animator.SetBool("turnLeft", true);
            animator.SetBool("turnRight", false);
            isFacingLeft = !isFacingLeft;


        } else if ( h>0 && isFacingLeft)
        {           
            animator.SetBool("turnRight", true);
            animator.SetBool("turnLeft", false);
            isFacingLeft = !isFacingLeft;


        } else
        {
            animator.SetBool("turnLeft", false);
            animator.SetBool("turnRight", false);
        }

        

        if (animator.GetBool("canJump") == true) //check if  player can jump
        {
            if (jumpKeyPressed && Mathf.Abs(v) > 0)
            {
                Jump();
                animator.SetBool("isJumping", true);
            }
            
        }


    }

    private void FixedUpdate()
    {
        HorizontalDisplacement();
    }

    public void HorizontalDisplacement() //use in FixedUpdate only
    {
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;
        float Ymovement = rb.velocity.y;
        float Xmovement = h;
        Vector2 displacement = new Vector2(Xmovement * speed, Ymovement);
        rb.velocity = displacement; //transform.translate moves the object independently of its physical characteristics

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 8)
        {
            animator.SetBool("isGrounded", true);
            animator.SetBool("isJumping", false);
            animator.SetBool("canJump", true);
        } 
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 8)
        {
            animator.SetBool("isGrounded", false);
            animator.SetBool("canJump", false);
        }
    }


    private void Jump()
    {
        animator.SetBool("isJumping", true);
        rb.AddForce(new Vector2(0, 12), ForceMode2D.Impulse);
        animator.SetBool("canJump", false);
    }

    public IEnumerator FreezeEnterScene()
    {
        frozen = true;
        yield return new WaitForSeconds(1);
        frozen = false;
    }
}
