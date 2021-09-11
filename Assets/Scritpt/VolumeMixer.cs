using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class VolumeMixer : MonoBehaviour
{
    public AudioMixer mixer;
    public string parametroMixer;

    private void Start()
    {
        if (PlayerPrefs.HasKey(parametroMixer))
        {
            mixer.SetFloat(parametroMixer, PlayerPrefs.GetFloat(parametroMixer));
        } else mixer.SetFloat(parametroMixer, 0);
    }

    public void MudarVolume(float volume)
    {
        mixer.SetFloat(parametroMixer, volume);
        PlayerPrefs.SetFloat(parametroMixer, volume);
    }
}
