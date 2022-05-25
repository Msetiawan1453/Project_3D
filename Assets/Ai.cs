using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Ai : MonoBehaviour
{
    public Transform[] waypoints;
    NavMeshAgent agent;
    int waypointIndex;

    Vector3 target;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        UpdateDestination();
    }


    void Update()
    {
      if (Vector3.Distance(transform.position, target) < 4)
        {
            iterateWaypointIndex();
            UpdateDestination();
        } 
    }

    // Update is called once per frame
    void UpdateDestination()
    {
        target = waypoints[waypointIndex].position;
        agent.SetDestination(target);
    }

    void iterateWaypointIndex()
    {
        waypointIndex++;
        if(waypointIndex == waypoints.Length)
        {
            waypointIndex = 0;
        }
    }
}
