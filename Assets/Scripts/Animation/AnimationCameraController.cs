using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationCameraController : MonoBehaviour {

	public GameObject player;
	private Vector3 positionOffset;
	Vector3 position = new Vector3();
	
	// Use this for initialization
	void Start () {
		positionOffset = transform.position - player.transform.position;

		position.y = 3.0f;


		
	}
	
	// Update is called once per frame
	void LateUpdate () {
		position.x = player.transform.position.x + positionOffset.x;
		position.z = player.transform.position.z + positionOffset.z;

		transform.position = position;

		//transform.position = player.transform.position + positionOffset;
		
		//transform.rotation = player.transform.rotation;

		

		
	}
}
