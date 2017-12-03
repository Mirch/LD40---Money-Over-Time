using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChestPanelMain : MonoBehaviour {

    public Text YourCoins;
    public Text ChestStatus;
    public Text Amount;
    public PlayerInventory Inventory;

    private ChestMain Chest;

	void Start () {
		
	}
	
	void Update () {
        YourCoins.text = "Your coins: " + Inventory.GetProgress();
        ChestStatus.text = "Chest status: " + Chest.GetProgress();

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            gameObject.SetActive(false);
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.lockState = CursorLockMode.Locked;
        }
	}

    public void SetChest(ChestMain chest)
    {
        Chest = chest;
    }

    public void Deposit()
    {
        Inventory.DepositTo(Convert.ToInt32(Amount.text), Chest);
        gameObject.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }
}
