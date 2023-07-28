using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepSpeed : MonoBehaviour
{//***Attach to the Manager for UI Slider of TimeScale
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DepartureSpeed()
    {
        GameObject slider = GameObject.Find("DepSeedSlider");
       VariableManagementScript.DepSpawnSpeed=slider.GetComponent<UnityEngine.UI.Slider>().value;
}}
