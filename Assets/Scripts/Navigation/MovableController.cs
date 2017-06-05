using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovableController : MonoBehaviour {

	public float speed;
	private bool selected = false;


	
	// Update is called once per frame
	void FixedUpdate () {
		if (selected){
			
			if (Input.GetKey(KeyCode.LeftArrow)){
				transform.Translate(-speed, 0, 0, Space.World);
			}
			else if (Input.GetKey(KeyCode.RightArrow)){
				transform.Translate(speed, 0, 0, Space.World);
			}
		
			if (Input.GetKey(KeyCode.UpArrow)){
				transform.Translate(0, 0, speed, Space.World);
			}
			else if (Input.GetKey(KeyCode.DownArrow)){
				transform.Translate(0, 0, -speed, Space.World);
			}
		


		}
	}

	void OnMouseDown(){
		if (selected){
			selected = false;
			
			return;
		}
		if (!selected){
			
			selected = true;
			
		}
	}

}
