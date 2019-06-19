using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratePlatform : MonoBehaviour {
    public GameObject platform;
    public GameObject player;

    private void Update() {
        SpawnNewPlatform();
        DeleteOldPlatforms();
    }

    private void DeleteOldPlatforms() {
        if (player.transform.position.z - transform.position.z > 30) {
            gameObject.SetActive(false);
            Destroy(this);
        }
    }

    private void SpawnNewPlatform() {
        if (player.transform.position.z - transform.position.z > 5) {
            Instantiate(platform, transform.TransformPoint(0, -1, 0), gameObject.transform.rotation);
        }
    }
}
