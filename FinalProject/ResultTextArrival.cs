
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//import TextMeshPro
using TMPro;

public class ResultTextArrival : MonoBehaviour
{
    //Attatch to TextMeshPro
    //**********************
    TextMeshProUGUI message; //Initialized in Start() method
   public int num=7;
   public GameObject cube;
    void Start()
    {
        message=GetComponent<TextMeshProUGUI>();
        num=VariableManagementScript.total_arrival;
        message.text=num.ToString()+" have arrived";
    }

    // Update is called once per frame
    void Update()
    {
         message=GetComponent<TextMeshProUGUI>();
        num=VariableManagementScript.total_arrival;
        message.text=num.ToString();
         message.text=num.ToString()+" have arrived in Iidabashi ";
         message.text+="of those "+VariableManagementScript.tozeiCount.ToString()+" have transfered to the Tozei line,";
          message.text+=VariableManagementScript.yuraCount.ToString()+" to the  Yuracacho line";
          message.text+="and " + VariableManagementScript.iidabashiFinal+" have Iidabashi as their final destination.";
          message.text+=VariableManagementScript.departures+"have left Iidabashi station.";


    }
    
}