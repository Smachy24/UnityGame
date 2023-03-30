using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;

    public void setVolume(float volume)
    {
        audioMixer.SetFloat("Music",volume);
    }

    public void setSoundVolume(float volume)
    {
        audioMixer.SetFloat("Sound", volume);
    }
}
