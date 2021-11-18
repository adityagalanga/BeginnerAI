using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimpleAICar : MonoBehaviour {

	public Transform goal;
	public Text readout;
	float acceleration = 5f;
	float deceleration = 5;

	float minSpeed = 0.0f;
	float maxSpeed = 100.0f;
	float brakeAngle = 20.0f;

	public float rotSpeed = 10.0f;
	float speed = 0;
	
	// Update is called once per frame
	void LateUpdate () {
		Vector3 lookAtGoal = new Vector3(goal.position.x, 
										this.transform.position.y, 
										goal.position.z);
		Vector3 direction = lookAtGoal - this.transform.position;

		this.transform.rotation = Quaternion.Slerp(this.transform.rotation, 
												Quaternion.LookRotation(direction), 
												Time.deltaTime*rotSpeed);
		if(Vector3.Angle(goal.forward,this.transform.forward) > brakeAngle)
		{
			speed = Mathf.Clamp(speed - (acceleration * Time.deltaTime), minSpeed, maxSpeed);
        }
        else
        {
			speed = Mathf.Clamp(speed + (acceleration * Time.deltaTime), minSpeed, maxSpeed);
		}


		this.transform.Translate(0,0,speed);
		AnalogueSpeedConverter.ShowSpeed(speed, minSpeed, maxSpeed);
		readout.text = "" + speed;
	}
}
