using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject settingsWindow;

    public void Quit()
    {
        Application.Quit();
    }

    public void Play()
    {
        SceneManager.LoadScene(2);
    }

    public void SettingButton()
    {
        settingsWindow.SetActive(true);
    }

    public void CloseSettings()
    {
        settingsWindow.SetActive(false);
    }
}
