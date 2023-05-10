using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class letterGenerator : MonoBehaviour
{
    public Text[] buttonletters;
    // Start is called before the first frame update

    void OnEnable(){
        foreach(Text letter in buttonletters){
            //letter.text = char.ToString(letterList.randomLetter()).ToUpper();
            letter.fontSize = changeFont.fontSize;
        }
    }

    // Generate a random letter for each button
    public void Start()
    {
        foreach(Text letter in buttonletters){
            letter.text = char.ToString(letterList.randomLetter()).ToUpper();
            letter.fontSize = changeFont.fontSize;
            Debug.Log(letter.fontSize);
        }
    }
    
}
