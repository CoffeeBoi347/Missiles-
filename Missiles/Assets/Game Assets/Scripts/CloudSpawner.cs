using System.Collections;
using UnityEngine;

public class CloudSpawner : MonoBehaviour
{
    [Header("Prefabs")]

    public GameObject[] spawnPos;
    public GameObject[] clouds;

    [Header("Positions")]

    public GameObject holdCloud;

    [Header("Timer Values")]

    public float timeToSpawn;

    [Header("Booleans")]

    public bool hasSpawned = false;

    private void Update()
    {
        if (!hasSpawned)
        {
            int randomSpawner = Random.Range(0, spawnPos.Length);
            int randomNum = Random.Range(0, clouds.Length);
            GameObject objToSpawn = clouds[randomNum];
            GameObject objSpawner = spawnPos[randomSpawner];
            Vector3 spawnedPosition = objSpawner.transform.position;
            spawnedPosition.z = 0f;
            Instantiate(objToSpawn, spawnedPosition, Quaternion.identity, holdCloud.transform);
            hasSpawned = true;
            StartCoroutine(SetHasSpawnedToFalse());
        }
    }

    private IEnumerator SetHasSpawnedToFalse()
    {
        yield return new WaitForSeconds(timeToSpawn);
        hasSpawned = false;
    }
}