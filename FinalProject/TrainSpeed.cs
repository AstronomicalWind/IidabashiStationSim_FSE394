using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainSpeedScript : MonoBehaviour
{//***Attach to the Manager for UI Slider of TimeScale
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TrainSpeed()
    {
        GameObject slider = GameObject.Find("TrainSpeedSlider");
       VariableManagementScript.trainSpeed=slider.GetComponent<UnityEngine.UI.Slider>().value;
}}
