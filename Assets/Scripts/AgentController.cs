using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentController : MonoBehaviour {

	//public Transform target;

	NavMeshAgent agent;

	public bool selected = false;
	private bool destinationSet = false;
	private Vector3 destination;




	void Start () {
		agent = GetComponent<NavMeshAgent>();
		
		
	}

	void Update(){
		// if (Input.GetMouseButtonDown(1)){
		// 	target.position = Input.mousePosition;
		// }
		if (Input.GetMouseButtonDown(1)){
			destinationSet = true;
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			// if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100)) {
   //                  destination = hit.point;
   //              }
			if (Physics.Raycast(ray, out hit, 100)){
				destination = hit.point;
			}


			
			

			
			//destination = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		}
		
		if (selected && destinationSet == true){
			agent.SetDestination(destination);
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




	//update method - old version (activates ALL agents when one is clicked)
	// ray = Camera.main.ScreenPointToRay(Input.mousePosition);
	// 	if (Input.GetMouseButtonDown(0)){
			

	// 		if (Physics.Raycast(ray, out hit)){

	// 			if (hit.transform.tag == "agent"){
	// 				if (selected){
	// 					selected = false;
	// 				}
	// 				else{
	// 					selected = true;
	// 				}
	// 			}
	// 		}
	// 	}


	// 	if (selected){
	// 		agent.SetDestination(target.position);
	// 	}
	
}
