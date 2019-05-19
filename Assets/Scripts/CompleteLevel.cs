using UnityEngine;
using UnityEngine.SceneManagement;

public class CompleteLevel : MonoBehaviour
{
    public void LoadNextLevel() {
        //load the next scene, check if exists to not have an error
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
