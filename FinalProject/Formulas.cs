
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//import TextMeshPro
using TMPro;

public class Formulas : MonoBehaviour
{
    //Attatch to TextMeshPro
    //**********************
    TextMeshProUGUI message; //Initialized in Start() method
   public float num=7;
   public GameObject cube;
    void Start()
    {
        message=GetComponent<TextMeshProUGUI>();
        num=(VariableManagementScript.departures+VariableManagementScript.total_arrival)/Time.time;
        message.text=num.ToString()+" enter/exit through Iidabashi station every 10 seconds";
    }

    // Update is called once per frame
    void Update()
    {
        message=GetComponent<TextMeshProUGUI>();
        num=(VariableManagementScript.departures+VariableManagementScript.total_arrival)/Time.time;
        message.text=num.ToString()+" are currently entering/exiting through Iidabashi station every 10 seconds";

    }
    
}