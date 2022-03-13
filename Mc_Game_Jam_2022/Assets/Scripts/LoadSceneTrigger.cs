using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadSceneTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    private bool changeScene;

    private void Start()
    {
        changeScene = false;
        this.gameObject.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 7)
        {
            changeScene = true;
        }
    }

    public bool getSceneState()
    {
        return changeScene;
    }

    public void setActive(bool newState)
    {
        this.gameObject.SetActive(newState);
    }
}
