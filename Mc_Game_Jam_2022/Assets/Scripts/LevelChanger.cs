using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{

    public Animator animator;
    private int sceneToLoad;
    public LoadSceneTrigger loadSceneTrigger;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
             if(loadSceneTrigger.getSceneState() == true)
             {
                FadeToLevel(1);
             }   
    }

    public void FadeToLevel(int levelIndex)
    {
        sceneToLoad = levelIndex;
        animator.SetTrigger("FadeOut");
    }
    public void OnFadeComplete()
    {
        SceneManager.LoadScene(sceneToLoad);
    }

}
