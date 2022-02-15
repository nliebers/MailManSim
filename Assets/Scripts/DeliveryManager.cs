using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DeliveryManager : MonoBehaviour
{
	public GameObject correctDeliveryItem;
	public GameObject deliverySpace;
	public Material completeMatieral;
	public TextMeshProUGUI deliverCount1;
	public TextMeshProUGUI deliverCount2;
	public GameObject houses;
	public GameObject badEnding;
	public GameObject goodEnding;
	
	private void OnTriggerEnter(Collider other)
	{
		Debug.Log(other.transform.gameObject.name);
		if(other.transform.gameObject.name == correctDeliveryItem.name)
		{
			deliverySpace.GetComponent<MeshRenderer>().material = completeMatieral;
			houses.GetComponent<DeliveryTrackerManager>().packagesDelivered += 1;
			houses.GetComponent<DeliveryTrackerManager>().score += 100;
			other.transform.gameObject.SetActive(false);
			deliverCount1.text = "Score: " + houses.GetComponent<DeliveryTrackerManager>().score.ToString();
			deliverCount2.text = "Score: " + houses.GetComponent<DeliveryTrackerManager>().score.ToString();
			if (houses.GetComponent<DeliveryTrackerManager>().packagesDelivered == 8 && houses.GetComponent<DeliveryTrackerManager>().score <= 500){
				badEnding.SetActive(true);
			}
			else if (houses.GetComponent<DeliveryTrackerManager>().packagesDelivered == 8){
				goodEnding.SetActive(true);
			}
		} 
	}
}
