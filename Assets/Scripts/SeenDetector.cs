using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeenDetector : MonoBehaviour
{
	public bool seen = false;
	public GameObject detector;
	
    void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player") {
            seen = true;
			detector.GetComponent<BoxCollider>().enabled = false;
        }
    }
}
