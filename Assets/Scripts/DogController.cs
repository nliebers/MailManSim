using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogController : MonoBehaviour
{
	private float time = 10;
    // Update is called once per frame
    void FixedUpdate()
    {
	   Debug.Log(time);
       if (time > 0) {
		   time -= Time.deltaTime;
	   }
	   else {
		   transform.Rotate(0, 180, 0);
		   time += 10;
	   }
    }
}
