using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class refreshButton : MonoBehaviour
{
    public GameObject gameFunctions;
    public AudioSource sounds;
    public AudioClip sound;

    // Refresh button plus TTS

    public void OnRefreshHover(){
        if(TTS.ttsOn){
        sounds.PlayOneShot(sound);
        }
    }
    public void refreshButtonPressed() {
        gameFunctions.GetComponent<resetButton>().resetButtonPressed();
        gameFunctions.GetComponent<letterGenerator>().Start();
    }
}
