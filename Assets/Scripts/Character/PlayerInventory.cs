using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{

    public int MaximumSlots = 50;

    public int OccupiedSlots = 0;

    void Start()
    {

    }

    void Update()
    {

    }

    public void DepositTo(int amount, ChestMain chest)
    {
        if (amount > OccupiedSlots) return;
        OccupiedSlots -= amount;
        int remaining = chest.Deposit(amount);
        if (remaining > 0) OccupiedSlots += remaining;

    }


    public int GetOccupiedSlots()
    {
        return OccupiedSlots;
    }

    public string GetProgress()
    {
        return OccupiedSlots + "/" + MaximumSlots;
    }

}
