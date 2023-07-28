using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepSpawn : MonoBehaviour
{
    // Start is called before the first frame update
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
        if (step>VariableManagementScript.DepSpawnSpeed)
        {
            step=0;
            for (int i=0;i<1;i++)
            {
                //print(ArrivalPassenger.story);
             GameObject temp=Instantiate(prefab,transform.position,Quaternion.identity);
            }
        }
    }
}

