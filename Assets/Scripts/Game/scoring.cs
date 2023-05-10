using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoring : MonoBehaviour
{
    public static int score;
    public Text scoreText;
    public Text scoreText2;

    // Handle showing score to player
    void OnEnable(){
        score = 0;
    }
    void Update()
    {
        scoreText.text = score.ToString();
        scoreText2.text = score.ToString();
    }

}
