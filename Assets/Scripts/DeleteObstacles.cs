using UnityEngine;

public class DeleteObstacles : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag.Equals("Obstacle") || collision.gameObject.tag.Equals("ImpossibleObstacle")) {
            collision.gameObject.SetActive(false);
            Destroy(collision.gameObject);
        }
    }
}
