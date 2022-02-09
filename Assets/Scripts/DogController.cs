using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogController : MonoBehaviour
{
	private float time = 10;
	public GameObject eyes;
	private bool huntingMode;
    // Update is called once per frame
    void FixedUpdate()
    {
		GameObject LineofSight = GameObject.Find("LineofSight");
		huntingMode = LineofSight.GetComponent<SeenDetector>().seen;
		if (!huntingMode) {
			if (time > 0) {
				 time -= Time.deltaTime;
			} 
			else {
				 transform.Rotate(0, 180, 0);
				time += 10;
		   }
		}
	}
}
