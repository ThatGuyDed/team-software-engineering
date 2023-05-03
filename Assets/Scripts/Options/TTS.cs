using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TTS : MonoBehaviour
{
    public static bool ttsOn = true;
    public Text ttsText;
    public AudioSource speaker;
    public AudioClip ttsOnTTS;
    public AudioClip ttsOffTTS;
    public void TTSButtonPressed(){
        if (ttsText.text == "Off"){
            ttsText.text = "On";
            speaker.PlayOneShot(ttsOnTTS);
            ttsOn = true;
        }
        else{
            ttsText.text = "Off";
            speaker.PlayOneShot(ttsOffTTS);
            ttsOn = false;
        }
    }
}
