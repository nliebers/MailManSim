using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDestination : MonoBehaviour
{
    public GameObject player;
    public bool huntingMode;
	
	void Update () {
		GameObject LineofSight = GameObject.Find("LineofSight");
		huntingMode = LineofSight.GetComponent<SeenDetector>().seen;
		if (huntingMode){
			UnityEngine.AI.NavMeshAgent agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
			agent.destination = player.transform.position;
			float dist = Vector3.Distance(transform.position, player.transform.position);
			if (dist < 1.0){
				Debug.Log("Got caught");
			}
			else {
				Vector3 dir = player.transform.position - transform.position;
				dir.y = 0;
				Quaternion rot = Quaternion.LookRotation(-1 * dir);
				transform.rotation = Quaternion.Lerp(transform.rotation, rot, 5.0f * Time.deltaTime);
			}
		}
	}
}
