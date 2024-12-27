using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NaviAgentTest : MonoBehaviour
{
    NavMeshAgent agent;
    public Transform cube;
    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        agent.SetDestination(cube.transform.position);
    }
}
