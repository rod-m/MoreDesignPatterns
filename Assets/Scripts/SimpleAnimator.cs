using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SimpleAnimator : MonoBehaviour
{
    private Animator anim;
    private NavMeshAgent agent;
    private Vector3 previousPosition;
   
    void Start()
    {
        anim = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (agent.remainingDistance < 0.1)
        {
            anim.SetFloat("Speed", 0);
        }
        else
        {
            anim.SetFloat("Speed", Speed());
        }
        
    }
    float Speed()
    {
        Vector3 curMove = transform.position - previousPosition;
        previousPosition = transform.position;
        return curMove.magnitude / Time.deltaTime;
    }
}
