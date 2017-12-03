using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PostProcessing;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [Range(0, 4)]
    public float Minutes;
    [Range(0, 60)]
    public int Seconds;

    public Text TimeDisplay;

    public GameObject GameOverPanel;
    public GameObject NextLevelPanel;

    public List<ChestMain> Chests;

    public PlayerInventory PlayerInventory;

    private float m_Minutes;
    private float m_Seconds;

    void Start()
    {
        m_Minutes = Minutes;
        m_Seconds = Seconds;

        Physics.gravity *= 20.0f;
        
    }


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            SceneManager.LoadScene("MainMenuScreen");
            Cursor.lockState = CursorLockMode.None;
            Destroy(GameObject.Find("Music"));
        }

        Time.timeScale = ((float)PlayerInventory.GetOccupiedSlots() / (float)PlayerInventory.MaximumSlots) * 2.5f + 1;


        if (m_Seconds >= 0)
            m_Seconds -= Time.deltaTime;
        else
        {
            m_Seconds = 60;
            m_Minutes--;
        }

        if (AreChestsOK())
            NextLevel();

        if (m_Minutes < 0)
        {
            if (!AreChestsOK())
                GameOver();
            else
            {
                NextLevel();
            }
        }

        else
        {

            string minDisplay = m_Minutes < 10 ? ("0" + (int)m_Minutes) : ((int)m_Minutes).ToString();
            string secDisplay = m_Seconds < 10 ? ("0" + (int)m_Seconds) : ((int)m_Seconds).ToString();


            TimeDisplay.text = "Time left: " + minDisplay + ":" + secDisplay;
        }
    }

    public void GameOver()
    {
        Cursor.lockState = CursorLockMode.None;
        GameOverPanel.SetActive(true);
    }

    void NextLevel()
    {
        Cursor.lockState = CursorLockMode.None;
        NextLevelPanel.SetActive(true);
    }

    bool AreChestsOK()
    {
        bool ok = true;
        foreach (ChestMain chest in Chests)
        {
            if (chest.OccupiedSlots < chest.MaximumSlots)
            {
                ok = false;
                break;
            }
        }
        return ok;
    }


}
