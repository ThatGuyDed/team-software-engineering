using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public AudioSource speaker;
    public AudioClip startTTS;
    public void StartButtonPressed(){
        Debug.Log("Start Button Pressed!");
        SceneManager.LoadSceneAsync("Game");
        
    }

    public void StartButtonHover(){
        if (TTS.ttsOn){
            speaker.PlayOneShot(startTTS);
        }
    }
}
