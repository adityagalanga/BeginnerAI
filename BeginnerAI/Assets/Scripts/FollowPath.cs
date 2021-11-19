using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowPath : MonoBehaviour
{
    public GameObject wpManager;
    GameObject[] wps;
    NavMeshAgent agent;
    public void Start()
    {
        wps = wpManager.GetComponent<WPManager>().waypoints;
        agent = this.GetComponent<NavMeshAgent>();
    }

    public void GoToHeli()
    {
        agent.SetDestination(wps[4].transform.position);
        //g.AStar(currentNode, wps[3]);
        //currentWP = 0;
    }

    public void GoToRuin()
    {
        agent.SetDestination(wps[2].transform.position);
        //g.AStar(currentNode, wps[2]);
        //currentWP = 0;
    }

    private void LateUpdate()
    {
    }
}
