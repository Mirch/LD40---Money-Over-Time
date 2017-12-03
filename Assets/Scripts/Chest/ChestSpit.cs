using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChestSpit : MonoBehaviour
{

    public int SecondsUntilSpit;
    public GameObject Coin;
    public GameObject SpitPoint;
    public Text SecDisplay;

    private float m_Seconds;

    void Start()
    {
        m_Seconds = SecondsUntilSpit;
    }

    void Update()
    {
        bool full = GetComponent<ChestMain>().GetOccupiedSlots() == GetComponent<ChestMain>().MaximumSlots;

        if (full)
        {
            m_Seconds -= Time.deltaTime;

            if (m_Seconds <= 0)
                SpitCoins();
        } else
        {
            m_Seconds = SecondsUntilSpit;
        }

        SecDisplay.text = "00:" + (m_Seconds < 10 ? "0" + (int)m_Seconds : ((int)m_Seconds).ToString());

    }

    void SpitCoins()
    {
        int nrOfCoins = GetComponent<ChestMain>().GetOccupiedSlots();

        for (int i = 0; i < nrOfCoins; i++)
            Instantiate(Coin, SpitPoint.transform.position, Quaternion.identity);

        GetComponent<ChestMain>().OccupiedSlots = 0;

    }
}
