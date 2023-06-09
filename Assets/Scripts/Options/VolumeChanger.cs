using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeChanger : MonoBehaviour
{
    public AudioMixer mixer;

    // Changes volume based on the slider value

    public void SetLevel (float sliderVal){
        mixer.SetFloat("Vol", Mathf.Log10(sliderVal) * 20);
    }
}
