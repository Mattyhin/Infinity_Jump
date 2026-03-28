using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonOpenScene : MonoBehaviour
{
    public string name = "Level 1";

    public void OpenLevel()
    {
        SceneManager.LoadScene(name);
    }
    public void QuitToMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1;
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}