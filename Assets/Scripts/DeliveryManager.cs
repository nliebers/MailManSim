using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeliveryManager : MonoBehaviour
{
	public GameObject correctDeliveryItem;
	public GameObject deliverySpace;
	public Material completeMatieral;
	
	private void OnTriggerEnter(Collider other)
	{
		Debug.Log(other.transform.gameObject.name);
		if(other.transform.gameObject.name == correctDeliveryItem.name)
		{
			deliverySpace.GetComponent<MeshRenderer>().material = completeMatieral;
		} 
	}
}
