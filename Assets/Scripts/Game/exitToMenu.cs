using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class exitToMenu : MonoBehaviour
{
    public GameObject midGame;
    public GameObject endGame;
    public GameObject game;
    public GameObject menu;
    public GameObject options;

    public AudioSource sounds;
    public AudioClip sound;

    public void OnETMHover(){
        if(TTS.ttsOn){
        sounds.PlayOneShot(sound);
        }
    }       

    public void exitToMenuButton(){
        midGame.SetActive(true);
        endGame.SetActive(false);
        menu.SetActive(true);
        game.SetActive(false);
        options.GetComponent<timerCount>().Reset();
    }
}
