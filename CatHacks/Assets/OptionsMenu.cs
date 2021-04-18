using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class OptionsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;

    public void AdjustVolume(float volume)
    {
        audioMixer.SetFloat("Volume", volume);
    }
}
