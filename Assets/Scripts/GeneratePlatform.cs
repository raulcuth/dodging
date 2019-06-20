using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratePlatform : MonoBehaviour {
    public GameObject player;
    public float currentOffset = 20f;
    private float deleteOffset;
    private bool shouldInstantiate = true;

    private void Start() {
        deleteOffset = currentOffset + currentOffset / 2;
    }

    private void Update() {
        SpawnNewPlatform();
        DeleteOldPlatforms();
    }

    private void DeleteOldPlatforms() {
        if (player.transform.position.z - transform.position.z > deleteOffset) {
            gameObject.SetActive(false);
            Destroy(gameObject);
            shouldInstantiate = true;
        }
    }

    private void SpawnNewPlatform() {
        if (player.transform.position.z - transform.position.z > currentOffset / 2 && shouldInstantiate) {
            gameObject.name = "InstantiatedPlatform";
            Instantiate(gameObject, transform.TransformPoint(0, 0, currentOffset), gameObject.transform.rotation);
            currentOffset += currentOffset;
            shouldInstantiate = false;
        }
    }
}
