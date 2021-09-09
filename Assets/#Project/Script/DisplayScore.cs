using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour
{
    public Text timeDisplay;
    public Text Score;
    public float timer;
    public int counter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        counter = PlayerPrefs.GetInt("Score",counter);
        
        timer += Time.deltaTime;
        Debug.Log(timer);

        timeDisplay.text = "Time: " + timer.ToString("N2");
        Score.text = "Score: " + counter.ToString();
        
    }
}