using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ChestDisplay : MonoBehaviour {

    private Text Text;
    public ChestMain Chest;

	void Start () {
        Text = GetComponent<Text>();
       // Chest = GetPar
	}
	
	void Update () {
        Text.text = Chest.GetProgress();
	}
}
