using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] catsPrefabs;
    public float Interval = 1f;
    private float timer = 0f;

    private void Update()
    {
        timer += Time.deltaTime;

        if(timer >= Interval)
        {
            SpawnCat();
            timer = 0f;
        }
    }

    private void SpawnCat()
    {
        int randomIndex = Random.Range(0, catsPrefabs.Length); // Seleciona um índice aleatório do array
        Vector3 spawnPosition = new Vector3(Random.Range(-5f, 5f), Random.Range(-3f, 3f), 0f);
        Instantiate(catsPrefabs[randomIndex], spawnPosition, Quaternion.identity);
    }
}
