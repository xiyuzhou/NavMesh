using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class ObjectController : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform target;
    void Start()
    {
        agent.SetDestination(target.position);
    }
    void Update()
    {

        if (Input.GetMouseButtonDown(1))
        {
            Ray movePosition = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(movePosition, out var hitInfo))
            {
                agent.SetDestination(hitInfo.point);
            }
        }
    }
}
