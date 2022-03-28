using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public bool isPause;
    public GameObject pausePanel;
    public string mainMenu;
    void Start()
    {
        isPause = false;
        pausePanel.SetActive(false);
    }

    void Update()
    {
        if (Input.GetButtonDown("pause"))
        {
            ChangePauseState();
        }
    }

    public void ChangePauseState()
    {
        isPause = !isPause;
        if (isPause)
        {
            pausePanel.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
            pausePanel.SetActive(false);
            Time.timeScale = 1f;
        }
    }

    public void BackToMain()
    {
        SceneManager.LoadScene(mainMenu);
        Time.timeScale = 1f;
    }

    public void Resume()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1f;
    }

    public void SwitchToPanels()
    {
        if (isPause)
        {
            pausePanel.SetActive(false);
            isPause = false;
        }
        else
        {
            pausePanel.SetActive(true);
            isPause = true;
        }
    }
}
