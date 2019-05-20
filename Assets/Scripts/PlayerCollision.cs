using UnityEngine;

public class PlayerCollision : MonoBehaviour {
    public PlayerMovement movement;

    private void OnCollisionEnter(Collision collisionInfo) {
        if (collisionInfo.collider.tag.Equals("ImpossibleObstacle")) {
            FindObjectOfType<GameManager>().EndGame();
        } else if (collisionInfo.collider.tag.Equals("Obstacle")) {
            //what to do???
        }
    }
}
