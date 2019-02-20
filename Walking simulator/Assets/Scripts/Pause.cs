using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{

    public static bool paused = false;

    public GameObject pausedUI;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (paused)
            {
                Resume();
            }
            else {
                Paused();
            }
        }
    }

    public void Resume() {
        pausedUI.SetActive(false);
        Time.timeScale = 1f;
        paused = false;
    }

    void Paused() {
        pausedUI.SetActive(true);
        Time.timeScale = 0f;
        paused = true;
    }

    public void LoadMenu() {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
