using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCam : MonoBehaviour
{
    // Start is called before the first frame update
    //***Attatch to Main Camera
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        if (Input.GetKey("w"))
        {
            pos.z+=0.05f;
        }

        if (Input.GetKey("s"))
        {
            pos.z-=0.05f;
        }
        if (Input.GetKey("d"))
        {
            pos.x+=0.05f;
        }
        if (Input.GetKey("a"))
        {
            pos.x-=0.05f;
        }

        transform.position=pos;//update position
        
    }
}
