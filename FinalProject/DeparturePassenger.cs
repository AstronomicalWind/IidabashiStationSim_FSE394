using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DeparturePassenger : MonoBehaviour
{
    public Transform goal;
    public GameObject departureZone;
    public NavMeshAgent agent;
    public int destination;
    // Start is called before the first frame update
    void Start()
    {
                 agent = GetComponent<NavMeshAgent>();
                 destination=Random.Range(0,2);
                          if (destination==0)
                          {
         departureZone= GameObject.FindGameObjectWithTag("Goal1");}
              if (destination==1)
                          {
         departureZone= GameObject.FindGameObjectWithTag("Goal2");}
                 goal=departureZone.GetComponent<Transform>();
                          agent.SetDestination(goal.position);
                       VariableManagementScript.departures++;   


         }

    

    // Update is called once per frame
    void Update()
    {
        //print(VariableManagementScript.ready2);
        //print(agent.GetComponent<NavMeshAgent>().isStopped);
    }

void OnTriggerEnter(Collider other)
    {
       
            
        // if (VariableManagementScript.ready2==false)
        // {
        //     agent.GetComponent<NavMeshAgent>().isStopped = true;
        //     print("aims");
        // }

        // else if(VariableManagementScript.ready2==true)
        // {
        //      agent.GetComponent<NavMeshAgent>().isStopped = false;
        // }}

    }
    void OnTriggerStay(Collider other)
    {
         if (other.tag=="Goal1"){
            
            
        if (VariableManagementScript.ready2==false)
        {
            agent.GetComponent<NavMeshAgent>().isStopped = true;
           // print("aims");
        }

        else if(VariableManagementScript.ready2==true)
        {
            Destroy(gameObject);
             //agent.GetComponent<NavMeshAgent>().isStopped = false;
        }}

        if (other.tag=="Goal2"){
            
            
        if (VariableManagementScript.ready==false)
        {
            agent.GetComponent<NavMeshAgent>().isStopped = true;
            //print("aims");
        }

        else if(VariableManagementScript.ready==true)
        {
            Destroy(gameObject);
             //agent.GetComponent<NavMeshAgent>().isStopped = false;
        }

        if (!agent.isOnNavMesh)
{
    Destroy(gameObject);
//    Vector3 warpPosition; //Set to position you want to warp to
//    agent.transform.position = warpPosition;
   agent.enabled = false;
//    agent.enabled = true;
}
        
         }

    }
    
}
