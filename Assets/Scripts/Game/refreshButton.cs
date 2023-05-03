using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class refreshButton : MonoBehaviour
{
    public GameObject gameFunctions;
    public void refreshButtonPressed() {
        gameFunctions.GetComponent<resetButton>().resetButtonPressed();
        gameFunctions.GetComponent<letterGenerator>().Start();
    }
}
