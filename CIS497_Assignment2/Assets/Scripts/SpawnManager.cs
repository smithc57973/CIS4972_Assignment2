using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    private float topBound = 6;
    private float bottomBound = -4;
    private float rightBound = 11;

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
        while (true)
        {
            SpawnRandomEnemy();
            yield return new WaitForSeconds(1f);
        }
    }
}
