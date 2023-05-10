using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class returnToMenu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject optionsMenu;
    public AudioSource speaker;
    public AudioClip returnTTS;


    // Handles playing TTS sounds and when the RTM button is pressed
    public void returnButtonPressed(){
        Debug.Log("Return Button Pressed!");
        mainMenu.SetActive(true);
        optionsMenu.SetActive(false);
    }
    public void returnButtonHover(){
        if (TTS.ttsOn){
        speaker.PlayOneShot(returnTTS);
        }
    }
}
