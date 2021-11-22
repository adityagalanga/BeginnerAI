using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowPlayer : MonoBehaviour
{
    public NavMeshAgent agent;
    public GameObject Follow;
    // Update is called once per frame
    void Update()
    {
        Debug.Log(Vector3.Distance(agent.transform.position, Follow.transform.position));
        agent.SetDestination(Follow.transform.position);
        if(Vector3.Distance(agent.transform.position,Follow.transform.position) > 3)
        {

        }
        else
        {
            Vector3 rotation = Follow.transform.position - agent.transform.position;
            agent.transform.rotation = Quaternion.Slerp(agent.transform.rotation, Quaternion.LookRotation(rotation), 10 * Time.deltaTime);
        }
    }
}
