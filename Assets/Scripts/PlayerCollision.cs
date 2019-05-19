using UnityEngine;

public class PlayerCollision : MonoBehaviour {
    public PlayerMovement movement;

    private void OnCollisionEnter(Collision collisionInfo) {
        if (collisionInfo.collider.tag.Equals("Object")) {
            movement.forwardForce -= 300;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
