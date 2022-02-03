using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public static bool _gamePaused = false;
    [SerializeField]
    private GameObject _pauseMenuUI;
    [SerializeField]
    private Button _buttonMenu;
    [SerializeField]
    private Button _buttonInfo;
    [SerializeField]
    private GameObject _info;
    [SerializeField]
    private Button _returnFromInfo;
    [SerializeField]
    private Button _resumeGame;
    [SerializeField]
    private Button _exitButton;

    private void Update()
    {
        _returnFromInfo.onClick.AddListener(ReturnOnPauseMenu);
        _buttonInfo.onClick.AddListener(OpenInfo);
        _buttonMenu.onClick.AddListener(Pause);
        _resumeGame.onClick.AddListener(Resume);
        _exitButton.onClick.AddListener(QuitGame);


        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (_gamePaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }

    }

    private void ReturnOnPauseMenu()
    {
        _info.SetActive(false);
    }

    private void OpenInfo()
    {
        _info.SetActive(true);
    }

    public void Resume()
    {
        _pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        _gamePaused = false;
    }

    public void Pause()
    {
        _pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        _gamePaused = true;
    }

    public void QuitGame()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
