using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class LanternController : MonoBehaviour
{

    public static int nbLanterns;
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
                nbLanterns--;
                Physics2D.IgnoreCollision(GetComponent<Collider2D>(), collision.gameObject.GetComponent<Collider2D>());
            }
        }
    }

    public static void setNbLanterns(int newNbLanterns)
    {
        nbLanterns = newNbLanterns;
    }
}
