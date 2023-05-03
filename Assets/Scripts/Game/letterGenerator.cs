using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class letterGenerator : MonoBehaviour
{
    public Text[] buttonletters;
    // Start is called before the first frame update
    public void Start()
    {
        foreach(Text letter in buttonletters){
            letter.text = char.ToString(letterList.randomLetter()).ToUpper();
        }
    }
    
}
