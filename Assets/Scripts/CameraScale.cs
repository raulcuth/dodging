using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScale : MonoBehaviour
{
    // Use this for initialization
    void Start() {
        Camera.main.orthographicSize = (20.0f / Screen.width * Screen.height / 2.0f);
    }
}
