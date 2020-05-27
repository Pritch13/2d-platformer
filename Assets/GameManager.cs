using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
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
        SceneManager.LoadScene("LevelOne");
    }
}
