using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{
    private PlayerController player;
    public Animator animator;
    private string sceneToLoad;
    // Start is called before the first frame update

    private void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    public void FadeToLevel(string sceneName)
    {
        player.FreezeEnterScene();
        sceneToLoad = sceneName;
        animator.SetTrigger("FadeOut");

    }
    public void OnFadeComplete()
    {
        SceneManager.LoadScene(sceneToLoad);
        
        
    }
}
