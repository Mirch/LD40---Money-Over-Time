using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestMain : MonoBehaviour
{

    public int MaximumSlots = 10;

    public int OccupiedSlots = 0;

    void Start()
    {
        gameObject.GetComponent<MeshRenderer>().material.color = Color.red;

    }

    void Update()
    {
        if (OccupiedSlots == MaximumSlots)
            gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
        else
            gameObject.GetComponent<MeshRenderer>().material.color = Color.red;

    }

    public int Deposit(int amount)
    {
        if (MaximumSlots == OccupiedSlots) return amount;

        int canAdd = MaximumSlots - OccupiedSlots;

        GetComponent<AudioSource>().Play();
        if (amount > canAdd)
        {
            OccupiedSlots += canAdd;
            return amount - canAdd;
        }
        else
        {
            OccupiedSlots += amount;
            return 0;
        }
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
