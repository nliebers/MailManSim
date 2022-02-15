using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoveDestination : MonoBehaviour
{
    public GameObject player;
    public bool huntingMode;
	public bool boneThrown;
	public GameObject houses;
	public TextMeshProUGUI deliverCount1;
	public TextMeshProUGUI deliverCount2;
	
	void Update () {
		GameObject LineofSight = GameObject.Find("LineofSight");
		huntingMode = LineofSight.GetComponent<SeenDetector>().seen;
		GameObject Bone = GameObject.Find("Dog_bone_low_poly");
		boneThrown = Bone.GetComponent<BoneController>().boneThrown;
		if (LineofSight.GetComponent<SeenDetector>().seen)
		{
			UnityEngine.AI.NavMeshAgent agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
			agent.destination = player.transform.position;
			float dist = Vector3.Distance(transform.position, player.transform.position);
			if (dist <= 0.5f)
			{
				LineofSight.GetComponent<SeenDetector>().seen = false;
				GameObject dog = GameObject.Find("angrydog");
				dog.SetActive(false);
				houses.GetComponent<DeliveryTrackerManager>().score -= 300;
				deliverCount1.text = "Score: " + houses.GetComponent<DeliveryTrackerManager>().score.ToString();
				deliverCount2.text = "Score: " + houses.GetComponent<DeliveryTrackerManager>().score.ToString();
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
				UnityEngine.AI.NavMeshAgent agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
				agent.destination = Bone.transform.position;
			}
		}
	}
}
