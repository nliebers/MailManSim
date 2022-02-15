using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerHitDetection : MonoBehaviour
{
	public GameObject houses;
	public TextMeshProUGUI deliverCount1;
	public TextMeshProUGUI deliverCount2;
	
    void OnTriggerEnter(Collider other) {
		if (other.transform.gameObject.tag == "Player"){
			Debug.Log("Player Hit");
			houses.GetComponent<DeliveryTrackerManager>().score -= 100;
			deliverCount1.text = "Score: " + houses.GetComponent<DeliveryTrackerManager>().score.ToString();
			deliverCount2.text = "Score: " + houses.GetComponent<DeliveryTrackerManager>().score.ToString();
		}
	}
}
