using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MuteButtonColor : MonoBehaviour {

    private Color OriginalColor;


	void Start () {
        OriginalColor = GetComponent<Image>().color;
	}
	
	void Update () {
		
	}

    public void Clicked()
    {
        if (GetComponent<Image>().color.Equals(OriginalColor)) GetComponent<Image>().color = Color.red;
        else GetComponent<Image>().color = OriginalColor;
    }
}
