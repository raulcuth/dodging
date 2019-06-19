using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratePlatform : MonoBehaviour {
    public GameObject player;
    public float currentOffset = 20f;
    private bool shouldInstantiate = true;

    private void Update() {
        SpawnNewPlatform();
        DeleteOldPlatforms();
    }

    private void DeleteOldPlatforms() {
        if (player.transform.position.z - transform.position.z > 30) {
            gameObject.SetActive(false);
            Destroy(gameObject);
            shouldInstantiate = true;
        }
    }

    private void SpawnNewPlatform() {
        if (player.transform.position.z - transform.position.z > 10 && shouldInstantiate) {
            gameObject.name = "InstantiatedPlatform";
            Instantiate(gameObject, transform.TransformPoint(0, 0, currentOffset), gameObject.transform.rotation);
            currentOffset += currentOffset;
            shouldInstantiate = false;
        }
    }
}
