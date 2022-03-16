using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadSceneTrigger : MonoBehaviour
{
    private static string sceneToLoad;
    // Start is called before the first frame update
    private bool changeScene;
    private LevelChanger levelChanger;

    private void Start()
    {
        GetComponent<Collider2D>().enabled = false;
        levelChanger = GameObject.Find("Level_changer").GetComponent<LevelChanger>();

        if (SceneManager.GetActiveScene().name == "Scene2_cave" || SceneManager.GetActiveScene().name == "Scene1_Desert")
        {
            LanternController.setNbLanterns(4);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
        if(SceneManager.GetActiveScene().name == "Scene2_cave")
        {
            Debug.Log(LanternController.nbLanterns);
            if (LanternController.nbLanterns == 0)
            {                
                GetComponent<Collider2D>().enabled = true;
            } else
            {
                GetComponent<Collider2D>().enabled = false;
            }                  
            switch (gameObject.layer)
            {
                case 12:
                    sceneToLoad = "Scene1_Desert";
                    break;
                case 13:
                    sceneToLoad = "Scene3_forest";
                    break;
            }
        }

        if(SceneManager.GetActiveScene().name == "Scene1_Desert")
        {
            sceneToLoad = "Scene2_cave";
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.gameObject.layer == 7)
        {
            levelChanger.FadeToLevel(sceneToLoad);
        }
    }

    public bool getSceneState()
    {
        return changeScene;
    }

    public void setActive(bool newState)
    {
        GetComponent<Collider2D>().enabled = newState;
    }

    public static string GetSceneToLoad()
    {
        return sceneToLoad;
    }
}
