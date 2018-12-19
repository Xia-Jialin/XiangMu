using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;
using System;

public class Player : MonoBehaviour
{

    private NavMeshAgent agent;
    private Animator animator;


    // Use this for initialization
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vector3;
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray,out hit))
            {
                vector3 = new Vector3(hit.point.x,this. transform.position.y, hit.point.z);
                Debug.Log(hit.point);
                agent.SetDestination(vector3);
                Debug.Log(vector3);
               
                
            }
           
        }
        Debug.Log(agent.remainingDistance);
        if (agent.remainingDistance==0)
        {
            Debug.Log("123");
            animator.Play("HumanoidIdle");
        }
        else
        { 
            animator.Play("HumanoidRun");
        }
    }
}
