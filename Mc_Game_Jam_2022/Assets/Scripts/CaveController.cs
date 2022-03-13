using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaveController : MonoBehaviour
{
    public BlockPathCollider blockPathCollider;
    private bool blockPath;
    private Animator animator;
    public LoadSceneTrigger loadSceneTrigger;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
    if(LanternController.nbLanternsSc1 == 0)
        {
            animator.SetBool("riseUp", true);
        }

        if (animator.GetCurrentAnimatorStateInfo(0).IsName("RiseUp"))
        {
            blockPathCollider.setState(false);
        } else
        {
            blockPathCollider.setState(true);
        }

        

    }

    private void ActivateNextScene()
    {
        loadSceneTrigger.setActive(true);
    }

}
