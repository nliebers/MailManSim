using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoneController : MonoBehaviour
{
    public bool boneThrown = false;
	Vector3 lastPos;
	
	void Start() {
		lastPos = transform.position;
	}

    void Update() {
        if (transform.position.x - lastPos.x > 0.1f) {
            GameObject LineofSight = GameObject.Find("LineofSight");
		    LineofSight.GetComponent<SeenDetector>().seen = false;
            boneThrown = true;
        }
    }
}
