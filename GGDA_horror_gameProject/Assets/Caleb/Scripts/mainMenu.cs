using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public GameObject settingsMenu;
    public void QuitGame()
    {
        Application.Quit();
    }


    public void changeLevel()
    {
        SceneManager.LoadScene("Car_Scene");


    }

    public void playCredits()
    {
        SceneManager.LoadScene("Credits");
    }

    private void Awake()
    {
        settingsMenu.SetActive(false);
    }

}
