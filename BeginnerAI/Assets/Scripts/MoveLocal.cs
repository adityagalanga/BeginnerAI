using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLocal : MonoBehaviour
{
    public Transform goal;
    float speed = 0.5f;
    float accuracy = 1.0f;
    float rotSpeed = 0.5f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookatGoal = new Vector3(goal.position.x, this.transform.position.y, goal.position.z);

        Vector3 direction = lookatGoal - this.transform.position;

        this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), Time.deltaTime * rotSpeed);
        //if(Vector3.Distance(transform.position,lookatGoal) > accuracy)
        //    this.transform.Translate(0, 0, speed * Time.deltaTime);
    }
}
