using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Monster : MonoBehaviour
{
    private NavMeshAgent navAgent;

    void Awake()
    {
        navAgent = GetComponent<NavMeshAgent>();
    }

    void Start()
    {
        navAgent.SetDestination(new Vector3(0f, 2f, 1f));
        navAgent.speed *= Random.Range(0.8f, 1.5f);
    }


   
}
