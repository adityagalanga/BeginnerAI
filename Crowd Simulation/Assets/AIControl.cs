using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIControl : MonoBehaviour {

	GameObject[] goalLocations;
	UnityEngine.AI.NavMeshAgent agent;
	Animator anim;

	// Use this for initialization
	void Start () {
		anim = this.GetComponent<Animator>();
		goalLocations = GameObject.FindGameObjectsWithTag("goal");
		agent = this.GetComponent<UnityEngine.AI.NavMeshAgent>();
		agent.SetDestination(goalLocations[Random.Range(0,goalLocations.Length)].transform.position);

		float sm = Random.Range(0.5f, 1.3f);
		agent.speed *= sm;
		anim.SetFloat("speedMult", sm);
		anim.SetFloat("wOffset", Random.Range(0.0f, 1.0f));
		anim.SetTrigger("isWalking");
	}
	
	// Update is called once per frame
	void Update () {
		if(agent.remainingDistance < 1)
        {
			agent.SetDestination(goalLocations[Random.Range(0, goalLocations.Length)].transform.position);
        }
	}
}
