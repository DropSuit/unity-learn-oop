using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] items;
    private int randomItem;
    private float waitTime = 3;
    private float xBounds = 9;
    private float yBounds = 9;
    [SerializeField] private float spawnInterval;

    private void Start()
    {
        randomItem = Random.Range(0, items.Length);
        InvokeRepeating("SpawnItem", waitTime, spawnInterval);
    }

    private void SpawnItem()
    {
        float xSpawn = Random.Range(-xBounds, xBounds);

        Vector2 spawnPoint = new Vector2(xSpawn, yBounds);

        randomItem = Random.Range(0, items.Length);

        Instantiate(items[randomItem],spawnPoint,gameObject.transform.rotation);
    }

}
