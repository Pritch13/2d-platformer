using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public AudioSource buttonPress;
    bool gameHasEnded = false;
    public void EndGame() {
        if(gameHasEnded == false) {
            gameHasEnded = true;
            Restart();
        }
    }

    public void Restart() {
        SceneManager.LoadScene("Menu");
    }

    public void PlayAgain() {
        SceneManager.LoadScene("Start");
    }

    public void PlayGame() {
        SceneManager.LoadScene("LevelOne");
    }

    public void PlaySelectSound() {
        buttonPress.Play();
    }
}
