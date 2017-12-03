using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

    public GameObject MenuLinks;
    public GameObject AboutPanel;
    public GameObject SelectLevelPanel;

    public GameObject AboutExitButton;

    public void NewGame()
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void About()
    {
        AboutPanel.SetActive(true);
        MenuLinks.SetActive(false);
    }

    public void ExitAbout()
    {
        AboutPanel.SetActive(false);
        MenuLinks.SetActive(true);
    }

    public void SelectLevelMenu()
    {
        SelectLevelPanel.SetActive(true);
        MenuLinks.SetActive(false);
    }

    public void ExitLevelMenu()
    {
        SelectLevelPanel.SetActive(false);
        MenuLinks.SetActive(true);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void Level1()
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void Level2()
    {
        SceneManager.LoadScene("Level3");
    }

    public void Level3()
    {
        SceneManager.LoadScene("Level1");
    }

    public void Level4()
    {
        SceneManager.LoadScene("Level2");
    }

    public void Level5()
    {
        SceneManager.LoadScene("Level4");
    }

}
