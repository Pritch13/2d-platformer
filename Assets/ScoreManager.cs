using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{

  public static ScoreManager instance;
  public TextMeshProUGUI currentScore;
  public TextMeshProUGUI highScore;

  public int score = 0;
    
    void Start()
    {
        if(instance == null) {
          instance = this;
        }
    }

    void Update() 
    {
      if(PlayerPrefs.GetInt("HighScore") < score) {
        highScore.text = "High Score: " + score;
      }

      if(PlayerPrefs.GetInt("HighScore") > score) {
        highScore.text = "High Score: " + PlayerPrefs.GetInt("HighScore").ToString();
      }
    }

    
  public void ChangeScore(int coinValue) {
    score = score + coinValue;
    currentScore.text = "X " +score.ToString();
  }
}
