using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
    //can be array for more obstacles
    public GameObject[] obstacles;
    //boundaries where to spawn
    public Vector3 spawnValues;
    public float spawnWait;
    public float spawnMostWait;
    public float spawnLeastWait;
    public int startWait;
    public bool stop;

    private int randObstacle;

    void Start() {
        StartCoroutine(waitSpawner());
    }

    void Update() {
        spawnWait = Random.Range(spawnLeastWait, spawnMostWait);
    }

    IEnumerator waitSpawner() {
        yield return new WaitForSeconds(startWait);

        while (!stop) {
            //random obstacle from the array
            //find a way to have more weight on spawning easier obstacles, harder
            //as the time goes by
            randObstacle = Random.Range(0, obstacles.Length);
            //calculate spawn positions(randomize) on X, Y should always be 1(or spawn falling obstacles?)
            //on Z spawn on the position of the Spawner object, or closer if falling obstacles
            Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, Random.Range(-spawnValues.z, spawnValues.z));
            //GameObject generatedObstacle = obstacles[randObstacle];
            //generatedObstacle.GetComponent<ObstacleMovement>().forwardForce *= 2;
            if (obstacles[randObstacle].tag.Equals("LongObstacle")) {
                Instantiate(obstacles[randObstacle], transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);
            } else {
                Instantiate(obstacles[randObstacle], spawnPosition + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);
            }

            yield return new WaitForSeconds(spawnWait);
        }
    }
}
