using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rigidBody;
    private Vector3 position;
    private float width;
    private float height;
    public float forwardForce = 2000f;
    public float sidewaysForce = 100f;
    float scoreMultiplier = 1;
    int maxScoreMultiplier = 5;

    void Awake() {
        width = (float)Screen.width / 2.0f;
        height = (float)Screen.height / 2.0f;

        // Position used for the cube.
        position = new Vector3(0.0f, 1.0f, 0.0f);
    }

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {

        if (scoreMultiplier <= maxScoreMultiplier) {
            scoreMultiplier += Time.deltaTime / 10;
        }
        //if (Input.touchCount > 0) {
        //    Touch touch = Input.GetTouch(0);
        //    if (touch.phase == TouchPhase.Moved) {
        //        Vector2 touchPosition = touch.position;
        //        touchPosition.x = (touchPosition.x - width) / width;
        //        position = new Vector3(-touchPosition.x, 1.0f, 0.0f);
        //        transform.position = position;
        //    }
        //}
        //add a forward force
        rigidBody.AddForce(0, 0, forwardForce * Time.deltaTime);
        if (Input.GetKey("d")) {
            rigidBody.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a")) {
            rigidBody.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        //check if player fell off the ground
        if (rigidBody.position.y < -1f) {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
