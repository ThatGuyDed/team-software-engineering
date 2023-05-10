using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeFont : MonoBehaviour
{
    public Slider fontSlider;
    public GameObject gameFunctions;
    public static int fontSize = 300;
    // Takes value from font slider and updates fonts
    public void ChangeSizeFont(){
        fontSize = (int)fontSlider.value;
        gameFunctions.GetComponent<letterGenerator>().Start();
    }
}
