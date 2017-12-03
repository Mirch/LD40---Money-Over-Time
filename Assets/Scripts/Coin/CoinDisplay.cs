using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinDisplay : MonoBehaviour {

    public PlayerInventory PlayerInventory;

    public Text Text;

	void Start () {
        Text = GetComponent<Text>();
	}
	
	void Update () {

        int playerCoins = PlayerInventory.GetOccupiedSlots();

        Text.text = "Coins: " + playerCoins + "/" + PlayerInventory.MaximumSlots;
	}
}
