using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeFont : MonoBehaviour
{
    public Slider fontSlider;
    public static int fontSize = 300;
    // Start is called before the first frame update
    public void ChangeSizeFont(){
        fontSize = (int)fontSlider.value;
    }
}
