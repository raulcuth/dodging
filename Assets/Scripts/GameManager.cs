using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;

    public void EndGame() {
        if (gameHasEnded == false) {
            gameHasEnded = true;
            //restart game, show menu
            //invoke restart with a delay
            Invoke("Restart", restartDelay);
        }
    }

    public void CompleteLevel() {
        //also stop player movement/other stuff
        completeLevelUI.SetActive(true);
    }

    void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
