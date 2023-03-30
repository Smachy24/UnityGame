using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;

    public Slider musicSlider;
    public Slider soundSlider;

    private void Start()
    {
        audioMixer.GetFloat("Music", out float musicVolumeForSlider);
        musicSlider.value = musicVolumeForSlider;

        audioMixer.GetFloat("Sound", out float soundVolumeForSlider);
        soundSlider.value = soundVolumeForSlider;
    }

    public void setVolume(float volume)
    {
        audioMixer.SetFloat("Music",volume);
    }

    public void setSoundVolume(float volume)
    {
        audioMixer.SetFloat("Sound", volume);
    }
}
