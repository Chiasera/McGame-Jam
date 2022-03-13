using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanternController : MonoBehaviour
{

    public static int nbLanternsSc1 = 4;
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 7)
        {
           
            if (FireflyController.getNbFireflies() != 0)
            {
                animator.SetBool("firefly", true);
                FireflyController.setNbFireflies(FireflyController.getNbFireflies() - 1);
                nbLanternsSc1--;
                Physics2D.IgnoreCollision(GetComponent<Collider2D>(), collision.gameObject.GetComponent<Collider2D>());
            }
        }
    }
}
