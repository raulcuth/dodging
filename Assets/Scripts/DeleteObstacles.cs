using UnityEngine;
using UnityEngine.UI;

public class DeleteObstacles : MonoBehaviour {
    public Text scoreText;
    public float obstacleScore;

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag.Contains("Obstacle")) {
            collision.gameObject.SetActive(false);
            Destroy(collision.gameObject);
            scoreText.text = (ParseFastInteger(scoreText.text) + obstacleScore).ToString();
        }
    }

    private int ParseFastInteger(string value) {
        int result = 0;
        foreach (char c in value) {
            result = 10 * result + (c - 48);
        }
        return result;
    }
}
