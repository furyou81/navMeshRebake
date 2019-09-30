using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour {
	
	public Camera cam;
	public NavMeshAgent agent;
	public NavMeshSurface surface;

	void Update () {
		
		if (Input.GetMouseButtonDown(0)) {
			Ray ray = cam.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			surface.BuildNavMesh();
			if (Physics.Raycast(ray, out hit)) {
				agent.SetDestination(hit.point);
			}
		}
	}
}
