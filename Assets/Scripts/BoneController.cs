using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoneController : MonoBehaviour
{
    public bool boneThrown = false;

    void OnTriggerEnter(Collider other) {
        if (other.transform.gameObject.tag == "Player") {
            GameObject dog = GameObject.Find("dog");
            dog.GetComponent<MoveDestination>().huntingMode = false;
            boneThrown = true;
        }
    }
}
