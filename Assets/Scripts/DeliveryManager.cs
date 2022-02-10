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
	public int packagesDelivered;
	
	private void Start() {
		packagesDelivered = 0;
	}
	
	private void OnTriggerEnter(Collider other)
	{
		Debug.Log(other.transform.gameObject.name);
		if(other.transform.gameObject.name == correctDeliveryItem.name)
		{
			deliverySpace.GetComponent<MeshRenderer>().material = completeMatieral;
			packagesDelivered += 1;
			other.transform.gameObject.SetActive(false);
			deliverCount1.text = "Delivered: " + packagesDelivered.ToString();
			deliverCount2.text = "Delivered: " + packagesDelivered.ToString();
			Debug.Log(packagesDelivered);
		} 
	}
}
