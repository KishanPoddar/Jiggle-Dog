using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstacle;
    public float spawnRate;
    readonly float xPosition = 2.2f;

    // Start is called before the first frame update
    void Start()
    {
        StartSpawning();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Spawn();
        }
    }

    void Spawn()
    {
        float randomX = Random.Range(-xPosition, xPosition);
        Vector2 spawnPos = new Vector2(randomX, transform.position.y);
        Instantiate(obstacle, spawnPos, Quaternion.identity);
    }

    void StartSpawning()
    {
        InvokeRepeating("Spawn", 1f, spawnRate);
    }

    public void StopSpawning()
    {
        CancelInvoke("Spawn");
    }
}
