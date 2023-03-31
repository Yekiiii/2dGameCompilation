using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;
    public int spawnTimer;
    public int spawnInterval;
    public float randX;
    public float randY;
    public GameObject zombie;
    
    
    // Start is called before the first frame update
    void Start()
    {
    
    }
    void Spawn() {
        randX = Random.Range(minX, maxX);
        randY = Random.Range(minY, maxY);
        Instantiate(zombie, transform.position + new Vector3(randX, randY, 0), transform.rotation);
    }
    // Update is called once per frame
    void Update()
    {
        if (Time.time > spawnTimer) {
            Spawn();
            spawnTimer = spawnTimer + spawnInterval;
        }
    } 
}
