using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableManagementScript : MonoBehaviour
{
    public static int total_arrival;
    public static int iidabashiFinal;
    public static int yuraCount;
    public static int tozeiCount;
    public static bool trainArrived=false;
        public static bool trainArrived2=false;

    public static float crowdWeight;
    public static float trainSpeed=20;
    public static bool trainHold=false;
        public static bool trainHold2=false;

    public static bool ready=false;
        public static bool ready2=false;
    public static int departures;
    public static float DepSpawnSpeed;
    public static float bufferTime;
    public static bool trainOutSpawn=false;
    // Start is called before the first frame update
    void Start()
    {
        bufferTime=trainSpeed/4;
        DepSpawnSpeed=1;
        print(DepSpawnSpeed);
    }

    // Update is called once per frame
    void Update()
    {
                print(total_arrival);

        //print(ready2);
        //print(trainOutSpawn);
       // print(total_arrival);
    }
}
