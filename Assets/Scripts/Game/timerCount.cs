using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timerCount : MonoBehaviour
{
    float timer;
    public Text timerText;
    public GameObject midGame;
    public GameObject endGame;
    // Handle setting up timer
    void OnEnable()
    {
        timer = TimerButton.timerNum * 60;
    }

    public void Reset(){
        timer = TimerButton.timerNum * 60;
    }

    // Update timer every frame
    void Update()
    {
        if(timer > 0){
            timer -= Time.deltaTime;
        }
        else{
            midGame.SetActive(false);
            endGame.SetActive(true);
        }
        timerText.text = ((int)timer).ToString();
    }
}
