using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//for the NavMesh
using UnityEngine.AI;
public class ArrivalPassenger : MonoBehaviour
{
    public static int story=0;
    public Transform goal;
    public GameObject arrivalGate;
    public NavMeshAgent agent;
    public int destination;
    // Start is called before the first frame update
    void Start()
    {
         destination=Random.Range(0,4);
         agent = GetComponent<NavMeshAgent>();
         if (destination==1){
         arrivalGate= GameObject.FindGameObjectWithTag("Exit1");}
         if (destination==2){
         arrivalGate= GameObject.FindGameObjectWithTag("Exit2");}
          if (destination==3){
         arrivalGate= GameObject.FindGameObjectWithTag("Tozei");}
          if (destination==0){
         arrivalGate= GameObject.FindGameObjectWithTag("Yura");}
        goal=arrivalGate.GetComponent<Transform>();
        
         agent.SetDestination(goal.position);
       
        
        //agent= GetComponent<NavMeshAgent>();
        //        goal=goal1.GetComponent<Transform>();
    //        agent.SetDestination(goal.position);   

    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Arrival1")
    {
        VariableManagementScript.total_arrival++;
        //print(VariableManagementScript.total_arrival++);
        //Destroy(gameObject);
    }

    if (other.tag=="Exit1"&&destination==1)
    {
                VariableManagementScript.iidabashiFinal++;

        Destroy(gameObject);
    }
    else  if (other.tag=="Exit2"&&destination==2)
    {
                        VariableManagementScript.iidabashiFinal++;

        Destroy(gameObject);
    }
    else  if (other.tag=="Tozei"&&destination==3)
    {
        VariableManagementScript.tozeiCount++;
        Destroy(gameObject);
    }
    else  if (other.tag=="Yura"&&destination==0)
    {
        VariableManagementScript.yuraCount++;
        Destroy(gameObject);
    }

    }
    
}
