using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//import TextMeshPro
using TMPro;

public class CurrentTime : MonoBehaviour
{
    //Attatch to TextMeshPro
    //**********************
    TextMeshProUGUI message; //Initialized in Start() method
    string timeValue;
    void Start()
    {
        message=GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        message.text=Time.time.ToString("F2");
        timeValue=message.text;
    }
    
}