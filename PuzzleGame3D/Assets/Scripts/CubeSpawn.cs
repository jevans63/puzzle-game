using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawn : MonoBehaviour
{
    public GameObject[] cube;
    public Transform[] spawnPoint;
    public float timeToBegin = 1f;
    public float timeBetween = 1f;
    
    void Start()
    {
        InvokeRepeating ("SpawnInitial", timeToBegin, timeBetween);
        StartCoroutine(BombPhase(15));
    }
        void SpawnInitial()
    {
        int cubeIndex = Random.Range (0, cube.Length-1);
        int cubeIndex2 = Random.Range (0, cube.Length-1);
        int cubeIndex3 = Random.Range (0, cube.Length-1);
        int spawnIndex = Random.Range (0, spawnPoint.Length);
        int spawnIndex2 = Random.Range (0, spawnPoint.Length);
        int spawnIndex3 = Random.Range (0, spawnPoint.Length);

        Instantiate(cube[cubeIndex], spawnPoint[spawnIndex].position, spawnPoint[spawnIndex].rotation);

        if(spawnIndex2 != spawnIndex && spawnIndex2 != spawnIndex3)
        {
            Instantiate(cube[cubeIndex2], spawnPoint[spawnIndex2].position, spawnPoint[spawnIndex2].rotation);
        }

        if(spawnIndex3 != spawnIndex && spawnIndex3 != spawnIndex2)
        {
            Instantiate(cube[cubeIndex3], spawnPoint[spawnIndex3].position, spawnPoint[spawnIndex3].rotation);
        }
        
        timeToBegin -= timeToBegin * .001f;
        timeBetween -= timeBetween * .001f;
    }

    void Spawn()
    {
        int cubeIndex = Random.Range (0, cube.Length);
        int cubeIndex2 = Random.Range (0, cube.Length);
        int cubeIndex3 = Random.Range (0, cube.Length);
        int spawnIndex = Random.Range (0, spawnPoint.Length);
        int spawnIndex2 = Random.Range (0, spawnPoint.Length);
        int spawnIndex3 = Random.Range (0, spawnPoint.Length);

        Instantiate(cube[cubeIndex], spawnPoint[spawnIndex].position, spawnPoint[spawnIndex].rotation);

        if(spawnIndex2 != spawnIndex && spawnIndex2 != spawnIndex3)
        {
            Instantiate(cube[cubeIndex2], spawnPoint[spawnIndex2].position, spawnPoint[spawnIndex2].rotation);
        }

        if(spawnIndex3 != spawnIndex && spawnIndex3 != spawnIndex2)
        {
            Instantiate(cube[cubeIndex3], spawnPoint[spawnIndex3].position, spawnPoint[spawnIndex3].rotation);
        }
        
        timeToBegin -= timeToBegin * .001f;
        timeBetween -= timeBetween * .001f;
    }
    IEnumerator BombPhase(int time)
    {
        yield return new WaitForSeconds(time);
        InvokeRepeating ("Spawn", timeToBegin, timeBetween);
    }
}
