using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

public class submitButton : MonoBehaviour
{
    public TextAsset textFile;
    string longLines;
    List<string> lines;

    public GameObject gameFunctions;
    public Text word;

    public AudioSource sounds;
    public AudioClip sound;

    public void OnSubmitHover(){
        if(TTS.ttsOn){
        sounds.PlayOneShot(sound);
        }
    }

    void Start(){
        longLines = textFile.text;

        lines = new List<string>();
        lines.AddRange(longLines.Split("\n"[0]));
        for(int i=0; i < lines.Count();i++){
            lines[i] = lines[i].ToUpper();
            lines[i] = Regex.Replace(lines[i], @"<[^>]+>|&nbsp;", "").Trim();
            lines[i] = Regex.Replace(lines[i], @"[^\u0020-\u007F]", string.Empty);
        }
    }
    public void submitButtonPressed(){
        if(word.text != ""){
            if(lines.Contains(word.text)){
                Debug.Log("Valid Word!");
                scoring.score += word.text.Length;
                word.text = "";
                gameFunctions.GetComponent<resetButton>().resetButtonPressed();
                gameFunctions.GetComponent<letterGenerator>().Start();
            }
            else{
                Debug.Log("Invalid Word!");
                gameFunctions.GetComponent<resetButton>().resetButtonPressed();
            }
        }
    }
}
