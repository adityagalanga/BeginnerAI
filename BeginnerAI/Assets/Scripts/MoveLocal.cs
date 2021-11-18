using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLocal : MonoBehaviour
{
    public Transform goal;
    float speed = 0.5f;
    float accuracy = 1.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookatGoal = new Vector3(goal.position.x, this.transform.position.y, goal.position.z);
        this.transform.LookAt(lookatGoal);
        if(Vector3.Distance(transform.position,lookatGoal) > accuracy)
            this.transform.Translate(0, 0, speed * Time.deltaTime);
    }
}
