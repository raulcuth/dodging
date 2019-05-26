using UnityEngine;

public class TouchMovement : MonoBehaviour {
    private void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (Input.touchCount > 0) {
            Touch touch = Input.GetTouch(0); // get first touch since touch count is greater than zero           

            if (touch.phase == TouchPhase.Stationary || touch.phase == TouchPhase.Moved) {

                // get mouse position in screen space
                // (if touch, gets average of all touches)
                Vector3 screenPos = Input.mousePosition;

                // set a distance from the camera
                screenPos.z = 10.0f;
                // convert mouse position to world space
                Vector3 worldPos = Camera.main.ScreenToWorldPoint(screenPos);
                worldPos.y = 0.625f;
                worldPos.z = 0.0f;

                // get current position of this GameObject
                Vector3 newPos = transform.position;
                // set x position to mouse world-space x position
                newPos.x = worldPos.x;

                // apply new position
                //transform.position = newPos;
                transform.Translate(Vector3.MoveTowards(transform.position, worldPos, 50 * Time.deltaTime) - transform.position);
            }
        }

        //check if player fell off the ground
        if (transform.position.y < -1f) {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
