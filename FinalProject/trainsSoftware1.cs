using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trainsSoftware1 : MonoBehaviour
{
    public float step=0;
    public float timer=0;
    public Material offColor;
    public GameObject[] TrainCart;
    public Material onColor;
    // Start is called before the first frame update
    void Start()
    {
        TrainCart=GameObject.FindGameObjectsWithTag("Cart2");
        step=VariableManagementScript.trainSpeed/2;
        //print(step);
    }

    // Update is called once per frame
    void Update()
    {
        step+=Time.deltaTime;
        if (step>VariableManagementScript.trainSpeed&&VariableManagementScript.trainArrived2==false)
        {VariableManagementScript.trainArrived2=true;
        
        step=0;
        timer=0;
        }
     
        if (VariableManagementScript.trainArrived2==true)
        {
           // VariableManagementScript.trainOutSpawn=false;
            VariableManagementScript.trainOutSpawn=true;
            step=0;
           // print(4444);
           
            VariableManagementScript.trainHold2=true;
            for (int i=0;i<TrainCart.Length;i++)
            {
            TrainCart[i].GetComponent< Renderer > ().material = onColor;
            }


        }
         if (VariableManagementScript.trainArrived2==false)
         {

            for (int i=0;i<TrainCart.Length;i++)
            {
            TrainCart[i].GetComponent< Renderer > ().material = offColor;
            }
         }
        if (VariableManagementScript.trainHold2==true)
        {
            timer+=Time.deltaTime;
            if (timer>3&&timer<VariableManagementScript.bufferTime)
            {
                //print(444);
                VariableManagementScript.ready2=true;
            }
            if (timer>VariableManagementScript.bufferTime)
           
            {VariableManagementScript.trainHold2=false;
             timer=0;
            VariableManagementScript.trainArrived2=false;
                            VariableManagementScript.ready2=false;

            }
               
        }
      
        
    }
}
