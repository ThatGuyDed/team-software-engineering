using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public AudioSource speaker;
    public AudioClip startTTS;

    public GameObject mainMenu;
    public GameObject game;

    // Handle start button pressed plus TTS

    public void StartButtonPressed(){
        Debug.Log("Start Button Pressed!");
        mainMenu.SetActive(false);
        game.SetActive(true);
        
    }

    public void StartButtonHover(){
        if (TTS.ttsOn){
            speaker.PlayOneShot(startTTS);
        }
    }
}
