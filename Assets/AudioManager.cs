using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public AudioClip[] playlist;
    public AudioSource audioSource;
    public AudioMixerGroup soundEffectMixer;

    public static AudioManager instance;

    private void Awake()
    {
        if(instance != null)
        {
            Debug.Log("Il y'a plus d'une instace de AudioManager dans la scène");
            return;
        }

        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        audioSource.clip = playlist[0];
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }

    public AudioSource PlayClipAt(AudioClip clip, Vector3 pos)
    {
        GameObject temp = new GameObject("TempAudio");
        temp.transform.position = pos;
        AudioSource audioSource = temp.AddComponent<AudioSource>();
        audioSource.clip = clip;
        audioSource.outputAudioMixerGroup = soundEffectMixer;
        audioSource.Play();
        Destroy(temp, clip.length);
        return audioSource;
    }
}
