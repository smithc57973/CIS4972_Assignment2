/*
 * Chris Smith
 * SpawnManager
 * Assignment 2
 * A script to manage enemy spawns.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    private float topBound = 11;
    private float bottomBound = -6.5f;
    private float rightBound = 11;
    public GameManager gm;

    // Update is called once per frame
    void Start()
    {
        StartCoroutine(Spawn());
    }

    void SpawnRandomEnemy()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(rightBound, Random.Range(topBound, bottomBound), 0);

        int index = Random.Range(0, enemyPrefabs.Length);

        // instantiate ball at random spawn location
        Instantiate(enemyPrefabs[index], spawnPos, enemyPrefabs[index].transform.rotation);
    }

    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(1f);
        while (!gm.gameOver)
        {
            SpawnRandomEnemy();
            int i = Random.Range(0, 5);
            yield return new WaitForSeconds(i);
        }
    }
}
