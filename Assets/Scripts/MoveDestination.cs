using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDestination : MonoBehaviour
{
    public GameObject player;
    public bool huntingMode;
	public bool boneThrown;
	
	void Update () {
		GameObject LineofSight = GameObject.Find("LineofSight");
		huntingMode = LineofSight.GetComponent<SeenDetector>().seen;
		GameObject Bone = GameObject.Find("Dog_bone_low_poly");
		boneThrown = Bone.GetComponent<BoneController>().boneThrown;
		if (huntingMode)
		{
			UnityEngine.AI.NavMeshAgent agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
			agent.destination = player.transform.position;
			float dist = Vector3.Distance(transform.position, player.transform.position);
			if (dist < 1.0)
			{
				Debug.Log("Got caught");
			}
			else
			{
				Vector3 dir = player.transform.position - transform.position;
				dir.y = 0;
				Quaternion rot = Quaternion.LookRotation(-1 * dir);
				transform.rotation = Quaternion.Lerp(transform.rotation, rot, 5.0f * Time.deltaTime);
			}
		}
		else {
			if (boneThrown) {
				Debug.Log("Bone has been thrown");
			}
		}
	}
}
