using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crowdiness : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void FSEIncrease()
    {
        GameObject slider = GameObject.Find("CrowdSlider");
       VariableManagementScript.crowdWeight=slider.GetComponent<UnityEngine.UI.Slider>().value;
    }
}
