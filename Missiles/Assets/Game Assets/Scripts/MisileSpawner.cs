using System.Collections.Generic;
using UnityEngine;

public class MisileSpawner : MonoBehaviour
{
    public List<GameObject> spawnerObjs = new List<GameObject> ();
    public Transform misileStores;
    public float timeLimit;
    public GameObject misileObj;
    public float timer;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > timeLimit)
        {
            int randomNum = Random.Range(0, spawnerObjs.Count);
            GameObject objToSpawn = spawnerObjs[randomNum];
            Instantiate(misileObj, objToSpawn.transform.position, Quaternion.identity, misileStores.transform);
            timer = 0f;
        }
    }
}
