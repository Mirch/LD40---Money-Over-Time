using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MenuTextHover : MonoBehaviour {

    private Text Text;
    private string OriginalText;

	void Start () {
        Text = GetComponent<Text>();
        OriginalText = Text.text;
	}

    public void Hover()
    {
        Text.text = ">" + OriginalText;
    }

    public void HoverExit()
    {
        Text.text = OriginalText;

    }
}


