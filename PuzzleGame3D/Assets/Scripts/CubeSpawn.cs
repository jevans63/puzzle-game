using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script is what spawns the falling blocks
// At start a function is called by InvokeRepeating called “SpawnInitial”
// For 30 seconds, SpawnInital spawns up to three random blocks(except the Orange bomb block) 
// to up to three random columns
// A StartCoroutine() function calls a method named BombPhase() 
// and passes a parameter for the amount of seconds to wait
// After the given seconds have passed, the BombPhase()ends the SpawnInital() 
// process via CancelInvoke() and calls InvokeRepeating() on the “Spawn” function 
// The “Spawn” function is almost identical to “SpawnInitial”
// except that it includes the Orange bomb blocks in the array of blocks which can spawn, 
// albeit at a reduced probability
public class CubeSpawn : MonoBehaviour
{
    public GameObject[] cube;
    public Transform[] spawnPoint;
    public float timeToBegin = 1f;
    public float timeBetween = 1f;
    
    void Start()
    {
        InvokeRepeating ("SpawnInitial", timeToBegin, timeBetween);
        StartCoroutine(BombPhase(30));
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
        CancelInvoke("SpawnInitial"); 
        InvokeRepeating ("Spawn", timeToBegin, timeBetween);
    }
}
