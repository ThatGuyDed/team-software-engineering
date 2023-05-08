using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoardButton : MonoBehaviour
{
    public Color32 textColour;
    public Color32 boxColour;
    public GameObject button;

    List<GameObject> validButtons;
    public List<string> validButtonsString;

    public AudioSource click;
    public AudioClip clickNoise;
    
    public Text letter;
    public Text word;
    public bool isPressed;
    public static GameObject lastButton;

    void Start(){
        validButtons = new List<GameObject>();
        foreach(string s in validButtonsString){
            validButtons.Add(GameObject.Find(s));
        }
    }
    public void boardButtonPressed(){
        
        if(!isPressed && !lastButton){
        button.GetComponent<Image>().color = Color.green;
        letter.color = textColour;
        word.text += letter.text;
        isPressed = true;
        lastButton = button;
        }
        else if (!isPressed && validButtons.Contains(lastButton)){
        button.GetComponent<Image>().color = Color.green;
        lastButton.GetComponent<Image>().color = boxColour;
        letter.color = textColour;
        word.text += letter.text;
        isPressed = true;
        lastButton = button;
        }
        //Debug.Log(button.transform.position.x - lastButton.transform.position.x);
        click.PlayOneShot(clickNoise);
        if (TTS.ttsOn){
            letterTTS.TTSLetter(letter.text);
        }
    }

    public void resetColours(){
        button.GetComponent<Image>().color = textColour;
        letter.color = boxColour;
    }
    
}
