using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeenDetector : MonoBehaviour
{
	public bool seen = false;
	
    void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player") {
            seen = true;
        }
    }
}
