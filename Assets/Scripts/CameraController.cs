using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	

	public float rotateSpeed;

	private Vector3 offset;

	public float speed;

	

	void LateUpdate () {
		

		if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.Tab)){
			if (Input.GetKey(KeyCode.LeftShift)){

				transform.Rotate(rotateSpeed, 0, 0);
			}
			else{
				transform.Rotate(-rotateSpeed, 0, 0);
			}
		}
		if (Input.GetKey(KeyCode.Q) || Input.GetKey(KeyCode.E)){
			if (Input.GetKey(KeyCode.Q)){

				transform.Rotate(0, -rotateSpeed, 0, Space.World);
			}
			else{
				transform.Rotate(0, rotateSpeed, 0, Space.World);
			}
		}

		if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)){
			if (Input.GetKey(KeyCode.A)){
				transform.Translate(-speed, 0, 0, Space.World);
			}
			else{
				transform.Translate(speed, 0, 0, Space.World);
			}
		}
		else{
			transform.Translate(0, 0, 0);
		}

		if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S)){
			if (Input.GetKey(KeyCode.W)){
				transform.Translate(0, 0, speed, Space.World);
			}
			else{
				transform.Translate(0, 0, -speed, Space.World);
			}
		}
		else{
			transform.Translate(0, 0, 0);
		}

		if (Input.GetKey("x") || Input.GetKey("z")){
			if (Input.GetKey("x")){
				transform.Translate(0, speed, 0, Space.World);
			}
			else{
				transform.Translate(0, -speed, 0, Space.World);
			}
		}
		else{
			transform.Translate(0, 0, 0);
		}
	}
}
