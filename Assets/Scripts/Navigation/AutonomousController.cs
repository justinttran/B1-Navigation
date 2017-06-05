using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutonomousController : MonoBehaviour {

	
	private bool oneWay = true;
	public float speed;

	private Vector3 start = new Vector3(0, 2.5f, -4.2f);
	private Vector3 end = new Vector3(0, 2.5f, -14.63f);

	void Update () {
		
		if (oneWay){
			transform.Translate(0, 0, speed);
			if (transform.position.z >= -4f){
				oneWay = false;
			}
		}
		else{
			transform.Translate(0, 0, -speed);
			if (transform.position.z <= -14f){
				oneWay = true;
			}
		}
			
		
	}
}