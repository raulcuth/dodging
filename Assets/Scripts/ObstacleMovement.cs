using UnityEngine;

public class ObstacleMovement : MonoBehaviour {

    public Rigidbody rigidBody;
    public float forwardForce = 200f;
    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        //can also add X movement for extra difficulty
        rigidBody.AddForce(0, 0, -forwardForce);
    }
}
