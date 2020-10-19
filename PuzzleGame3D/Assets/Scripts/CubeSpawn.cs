using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawn : MonoBehaviour
{
    public GameObject[] cube;
    public Transform spawnPoint;
    public float timeToBegin;
    public float timeBetween;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating ("Spawn", timeToBegin, timeBetween);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn()
    {
        int cubeIndex = Random.Range (0, cube.Length);
        Instantiate(cube[cubeIndex], spawnPoint.position, spawnPoint.rotation);
    }
}
