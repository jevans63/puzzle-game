using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void StartGameButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");
    }
    public void ExitGameButton()
    {
        Application.Quit();
    }
    public void HowToPlayButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("HowToPlay");
    }
    public void GoBackButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
    }
}