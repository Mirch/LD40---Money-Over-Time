using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRot : MonoBehaviour {

	void Start () {
		
	}
	
	void Update () {

        float startRotationTime = 0;
        if (Time.timeSinceLevelLoad > startRotationTime)
        {
            transform.rotation = Quaternion.Euler(0, Mathf.Sin(Time.realtimeSinceStartup - startRotationTime) * 3, 0);
        }
    }
}
