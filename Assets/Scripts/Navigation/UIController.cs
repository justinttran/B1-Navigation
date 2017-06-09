using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class UIController : MonoBehaviour {

	public Text agentsSelected;
	private AgentController script;

	
	
	
	void Update () {
	// 	agentsSelected.text = "Agents selected: ";
	// 	foreach (GameObject agent in GameObject.FindGameObjectsWithTag("agent")){
	// 		script = agent.GetComponent<AgentController>();
	// 		if (script.selected == true){
	// 			agentsSelected.text = agentsSelected.text + agent.name + ", ";
	// 		}
	// 	}
	// 	agentsSelected.text = agentsSelected.text.Substring(0, agentsSelected.text.Length - 2);
	 }
}
