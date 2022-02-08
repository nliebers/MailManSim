using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myson : MonoBehaviour
{

    void Update()
    {
        this.transform.position = this.transform.position + new Vector3(0.01f, 0.005f, 0.0f);
    }
}
