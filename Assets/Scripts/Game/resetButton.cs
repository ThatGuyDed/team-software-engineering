using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class resetButton : MonoBehaviour
{
    public Text word;
    public GameObject[] buttons;
    public AudioSource sounds;
    public AudioClip sound;

    public void OnResetHover(){
        if(TTS.ttsOn){
        sounds.PlayOneShot(sound);
        }
    }

    public void resetButtonPressed(){
        BoardButton.lastButton = null;
        word.text = "";
        foreach(GameObject button in buttons){
            button.GetComponent<BoardButton>().resetColours();
            button.GetComponent<BoardButton>().isPressed = false;
        }
    }


}
