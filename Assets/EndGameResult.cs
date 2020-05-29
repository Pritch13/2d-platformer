using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndGameResult : MonoBehaviour
{
    public static EndGameResult instance;
    public TextMeshProUGUI text;
    int score = 0;

    void Start()
    {
        if(instance == null) {
            instance = this;
        }
        GetResult();
    }


        void GetResult() {
        score = ScoreManager.instance.score;
        text.text = "Score: " +score.ToString();

        if(score > PlayerPrefs.GetInt("HighScore")) {
            PlayerPrefs.SetInt("HighScore", score);
        }
        
    }
}
