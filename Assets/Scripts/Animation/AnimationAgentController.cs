using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AnimationAgentController : MonoBehaviour {

	Animator anim;
	NavMeshAgent agent;

	public bool selected = false;
	private bool destinationSet = false;
	private Vector3 destination;

	private bool running = false;


	void Start () {
		anim = GetComponent<Animator>();
		agent = GetComponent<NavMeshAgent>();
		//agent.autoTraverseOffMeshLink = false;
		
	}
	
	void Update(){

		if (Input.GetMouseButtonDown(1)){
			destinationSet = true;
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

			if (Physics.Raycast(ray, out hit, 100)){
				destination = hit.point;
			}

		}
		
		if (selected && destinationSet == true){
			agent.SetDestination(destination);


			if (agent.remainingDistance > agent.radius){
				if (running == true){
					
					anim.SetBool("walking", true);
					anim.SetBool("running", true);

					agent.speed = 4;
				}
				else{
					anim.SetBool("running", false);
					anim.SetBool("walking", true);
					
				}
			}
			else{
				anim.SetBool("walking", false);
				anim.SetBool("running", false);
			}

			if (Input.GetKeyDown(KeyCode.Space)){
				if (running == true){
					running = false;
					anim.SetBool("running", false);
					agent.speed = 2;
					
				}
				else{
					running = true;
					anim.SetBool("running", true);
					agent.speed = 4;
				}
			}

			// if (agent.isOnOffMeshLink){
			// 	anim.SetBool("jump", true);
			// 	// agent.CompleteOffMeshLink();
			// }
			// else{
			// 	anim.SetBool("jump", false);
			// }

			if (agent.transform.position == agent.nextOffMeshLinkData.startPos){
				Debug.Log("here");
				agent.Stop();
				anim.SetBool("jump", true);

			}
			//anim.SetBool("jump", false);

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
