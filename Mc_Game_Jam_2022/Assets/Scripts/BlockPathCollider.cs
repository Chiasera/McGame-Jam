using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockPathCollider : MonoBehaviour
{

    private bool canGoThrough;
    // Start is called before the first frame update
    void Start()
    {
        canGoThrough = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (canGoThrough)
        {
            Physics2D.IgnoreCollision(GetComponent<Collider2D>(), GameObject.Find("Player").GetComponent<Collider2D>(), true);
        } else if (!canGoThrough)
        {
            Physics2D.IgnoreCollision(GetComponent<Collider2D>(), GameObject.Find("Player").GetComponent<Collider2D>(), false);

        }
    }

    public void setState(bool newState) {
        canGoThrough = newState;
    }
}
