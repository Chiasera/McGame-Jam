using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireflyController : MonoBehaviour
{
    private static int nbFireflies = 0;
    

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static int getNbFireflies()
    {
        return nbFireflies;
    }

    public static void setNbFireflies(int newNumber)
    {
        nbFireflies = newNumber;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 7)
        {
            nbFireflies++;
            GameObject.Destroy(this.gameObject);
        }
    }

}
