using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FireflyScore : MonoBehaviour
{
    
    public Text fireflyCounter;
    public LanternController refLantern;
    public FireflyController fireflyController;

    // Start is called before the first frame update
    void Start()
    {
        fireflyCounter.text = "0"; 
        
    }

    // Update is called once per frame
    void Update()
    {
        fireflyCounter.text = FireflyController.getNbFireflies().ToString();
    }  
}
