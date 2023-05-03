using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerButton : MonoBehaviour
{
    public Text timerText;
    public static int timerNum = 3;
    public void timerButtonPressed(){
        timerText.text = ((int.Parse(timerText.text) + 1) % 21).ToString();
        timerNum = Mathf.Max(1,int.Parse(timerText.text) % 21);
        if (timerText.text == "0"){
            timerText.text = "1";
        }
    }
}
