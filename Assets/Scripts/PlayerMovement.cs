using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rigidBody;
    public float forwardForce = 2000f;
    public float sidewaysForce = 100f;

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
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
