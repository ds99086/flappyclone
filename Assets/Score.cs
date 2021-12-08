using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    //public so it can be displayed
    //static so it can be called from outside. 
    public static int score = 0;
    public static int bestScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Text scoreText = GetComponent<Text>();
        scoreText.text = score.ToString();
        
    }
}
