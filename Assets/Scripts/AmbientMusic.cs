using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbientMusic : MonoBehaviour {


	void Start () {
        DontDestroyOnLoad(gameObject);
        
	}
	
	void Update () {
		
	}

    public void StopMusic()
    {

        GetComponent<AudioSource>().enabled = !(GetComponent<AudioSource>().enabled);
    }
}
