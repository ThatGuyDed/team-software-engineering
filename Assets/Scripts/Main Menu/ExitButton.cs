using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButton : MonoBehaviour
{
    public AudioSource speaker;
    public AudioClip exitTTS;
    public void ExitButtonPressed(){
        Debug.Log("Exit Button Pressed!");
        Application.Quit();
    }

    public void ExitButtonHover(){
        if (TTS.ttsOn){
            speaker.PlayOneShot(exitTTS);
        }
    }
}
