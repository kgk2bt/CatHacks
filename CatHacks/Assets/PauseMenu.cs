using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool gamePaused = false;
    public GameObject pauseMenuUI;
    public AudioMixer audioMixer;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(gamePaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gamePaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gamePaused = true;
    }

    public void AdjustVolume(float volume)
    {
        audioMixer.SetFloat("Volume", volume);
    }

    public void Menu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }
}
