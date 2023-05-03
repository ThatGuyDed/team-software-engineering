using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class resetButton : MonoBehaviour
{
    public Text word;
    public GameObject[] buttons;
    public void resetButtonPressed(){
        BoardButton.lastButton = null;
        word.text = "";
        foreach(GameObject button in buttons){
            button.GetComponent<BoardButton>().resetColours();
            button.GetComponent<BoardButton>().isPressed = false;
        }
    }
}
