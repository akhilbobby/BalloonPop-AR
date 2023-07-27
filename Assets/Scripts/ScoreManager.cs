using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highscoreText;

    int score = 0;
    int highscore = 0;

    private void Awake()
    {
        instance = this; 
    }

  
    void Start()
    {
        //the 0 is to show default value
        highscore = PlayerPrefs.GetInt("highscore", 0);

        scoreText.text = score.ToString() + " BALLOONS";
        highscoreText.text = "HIGHSCORE: " + highscore.ToString();
    }
 
    public void AddPoint()
    {
        score += 1;
        scoreText.text = score.ToString() + " BALLOONS";

        // PLayerPrefs - a class that stores Player preferences between game sessions
        if(highscore < score)
            PlayerPrefs.SetInt("highscore", score);
    }
}
