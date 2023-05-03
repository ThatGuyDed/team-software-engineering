using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class exitToMenu : MonoBehaviour
{
    public GameObject midGame;
    public GameObject endGame;
    public void exitToMenuButton(){
        midGame.SetActive(true);
        endGame.SetActive(false);
        SceneManager.LoadSceneAsync("Menu");
    }
}
