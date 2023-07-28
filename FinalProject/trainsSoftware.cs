// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class trainsSoftware : MonoBehaviour
// {
//     public float step=0;
//     public float timer=0;
//     public Material offColor;
//     public GameObject[] TrainCart;
//     public Material onColor;
//     // Start is called before the first frame update
//     void Start()
//     {
//         TrainCart=GameObject.FindGameObjectsWithTag("Cart1");
//         print(VariableManagementScript.trainSpeed);
//     }

//     // Update is called once per frame
//     void Update()
//     {
//         step+=Time.deltaTime;
//         if (step>VariableManagementScript.trainSpeed&&VariableManagementScript.trainArrived==false)
//         {VariableManagementScript.trainArrived=true;
        
//         step=0;
//         timer=0;
        
//         }
     
//         if (VariableManagementScript.trainArrived==true)
//         {
//            // VariableManagementScript.trainOutSpawn=false;
//             VariableManagementScript.trainOutSpawn=true;
//             step=0;
//            // print(4444);
           
//             VariableManagementScript.trainHold=true;
//             for (int i=0;i<TrainCart.Length;i++)
//             {
//             TrainCart[i].GetComponent< Renderer > ().material = onColor;
//             }


//         }
//          if (VariableManagementScript.trainArrived==false)
//          {
//             timer+=Time.deltaTime;
//             for (int i=0;i<TrainCart.Length;i++)
//             {
//             TrainCart[i].GetComponent< Renderer > ().material = offColor;
//             }
//          }
//         if (VariableManagementScript.trainHold==true)
//         {
//             if (timer>3&&timer<8)
//             {
//                 //print(444);
//                 VariableManagementScript.ready=true;
//             }
//             if (timer>8)
//             {VariableManagementScript.trainHold=false;
//             VariableManagementScript.trainArrived=false;
//                             VariableManagementScript.ready=false;
               
//         }
      
        
//     }
// }}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trainsSoftware : MonoBehaviour
{
    public float step=0;
    public float timer=0;
    public Material offColor;
    public GameObject[] TrainCart;
    public Material onColor;
    // Start is called before the first frame update
    void Start()
    {
        TrainCart=GameObject.FindGameObjectsWithTag("Cart1");
        //print(step);
    }

    // Update is called once per frame
    void Update()
    {
        step+=Time.deltaTime;
        if (step>VariableManagementScript.trainSpeed&&VariableManagementScript.trainArrived==false)
        {VariableManagementScript.trainArrived=true;
        
        step=0;
        timer=0;
        }
     
        if (VariableManagementScript.trainArrived==true)
        {
           // VariableManagementScript.trainOutSpawn=false;
            VariableManagementScript.trainOutSpawn=true;
            step=0;
           // print(4444);
           
            VariableManagementScript.trainHold=true;
            for (int i=0;i<TrainCart.Length;i++)
            {
            TrainCart[i].GetComponent< Renderer > ().material = onColor;
            }


        }
         if (VariableManagementScript.trainArrived==false)
         {

            for (int i=0;i<TrainCart.Length;i++)
            {
            TrainCart[i].GetComponent< Renderer > ().material = offColor;
            }
         }
        if (VariableManagementScript.trainHold==true)
        {
            timer+=Time.deltaTime;
            if (timer>3&&timer<VariableManagementScript.bufferTime)
            {
                //print(444);
                VariableManagementScript.ready=true;
            }
            if (timer>VariableManagementScript.bufferTime)
           
            {VariableManagementScript.trainHold=false;
             timer=0;
            VariableManagementScript.trainArrived=false;
                            VariableManagementScript.ready=false;

            }
               
        }
      
        
    }
}
