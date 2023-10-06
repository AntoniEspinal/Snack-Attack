using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Timer : MonoBehaviour
{
    public TMP_Text textDisplay;
    public float secondsLeft = 60;
    public bool takingAway = false;

    // Start is called before the first frame update
    void Start()
    {
        textDisplay.text = "00:" + secondsLeft.ToString();
    }
        

    // Update is called once per frame
    void Update()
    {
        float newTime;
        secondsLeft -= Time.deltaTime;
        newTime = Mathf.Floor(secondsLeft);
        //secondsLeft = (int)secondsLeft;
        textDisplay.text = "00:" + newTime.ToString();
        
    }

}
