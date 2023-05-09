using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColourChanger : MonoBehaviour
{
    public Color32[] cameraBackgrounds;
    public Color32[] buttonBackgrounds;
    public Color32[] textColors;
    public Camera mainCam;
    public int colorCounter = 0;
    public Image[] imgs;
    public Text[] texts;


    public void OnColourButtonPressed(){
        colorCounter++;
        colorCounter = colorCounter % cameraBackgrounds.Length;
        mainCam.backgroundColor = cameraBackgrounds[colorCounter];

        foreach (Image img in imgs)
        {
        img.color = buttonBackgrounds[colorCounter];
            foreach (Text t in img.GetComponentsInChildren<Text>()){
                t.color = textColors[colorCounter];
            }
        }

        foreach (Text t in texts)
        {
            t.color = textColors[colorCounter]; 
        }
    }


}
