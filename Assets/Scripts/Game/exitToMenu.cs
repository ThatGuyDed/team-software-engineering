using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class exitToMenu : MonoBehaviour
{
    public GameObject midGame;
    public GameObject endGame;
    public GameObject game;
    public GameObject menu;
    public void exitToMenuButton(){
        midGame.SetActive(true);
        endGame.SetActive(false);
        menu.SetActive(true);
        game.SetActive(false);
    }
}
