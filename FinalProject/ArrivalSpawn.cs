using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrivalSpawn1 : MonoBehaviour
{
    public GameObject prefab;
    public float step=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        step+=Time.deltaTime;
        if (step>VariableManagementScript.bufferTime&&VariableManagementScript.trainArrived2==true)
        {
            step=0;
            for (int i=0;i<VariableManagementScript.crowdWeight;i++)
            {
                //print(ArrivalPassenger.story);
             GameObject temp=Instantiate(prefab,transform.position,Quaternion.identity);
            }
        }
    }
}
