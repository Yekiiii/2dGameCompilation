using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    private float obstacleForce = 50000;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        MoveObstacle();
    }

    public void MoveObstacle()
    {
        rb.AddForce(transform.up * obstacleForce, ForceMode2D.Impulse);
    }
    
    // Update is called once per frame
    void Update()
    {

    }
}
