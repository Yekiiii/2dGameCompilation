using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject Ball1;
    public float MaxY;
    public float MinY;
    public float MaxX;
    public float MinX;
    public float spawnTime;
    public float spawnInterval;
    float randX;
    float randY;
    // Start is called before the first frame update
    void Start()
    {

    }
    void spawn()
    {
        randX = Random.Range(MinX, MaxX);
        randY = Random.Range(MinY, MaxY);
        Instantiate(Ball1, transform.position + new Vector3(randX, randY, 0), transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > spawnTime)
        {
            spawn();
            spawnTime = Time.time + spawnInterval;
        }
    }
}
