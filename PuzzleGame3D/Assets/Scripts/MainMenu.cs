using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script is the controller for all of the buttons on the Main Menu and How To Play section
// They work mostly by calling the SceneManager.LoadScene(“SceneName”) method
// The exception being the ExitGameButton() which calls Application.Quit()
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