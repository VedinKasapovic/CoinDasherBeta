using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Load Scene based on selected difficulty
    public void LoadEasyMode()
    {
        SceneManager.LoadScene("EasyScene");
    }

    public void LoadNormalMode()
    {
        SceneManager.LoadScene("NormalScene");
    }

    public void LoadHardMode()
    {
        SceneManager.LoadScene("HardScene");
    }

    // Quit Game
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Player Has Quit The Game");
    }
}
