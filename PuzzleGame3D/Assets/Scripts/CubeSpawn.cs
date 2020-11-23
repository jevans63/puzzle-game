using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawn : MonoBehaviour
{
    public GameObject[] cube;
    public Transform[] spawnPoint;
    public float timeToBegin;
    public float timeBetween;
    
    void Start()
    {
        InvokeRepeating ("Spawn", timeToBegin, timeBetween);
    }

    void Spawn()
    {
        int cubeIndex = Random.Range (0, cube.Length);
        int spawnIndex = Random.Range (0, spawnPoint.Length);
        Instantiate(cube[cubeIndex], spawnPoint[spawnIndex].position, spawnPoint[spawnIndex].rotation);
        timeBetween += 0.01f;
    }
}
