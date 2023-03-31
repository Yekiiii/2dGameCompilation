using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int rocketSpeed =5;
    private Rigidbody2D rb;
    private Vector2 playerdir;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float dirY = Input.GetAxisRaw("Vertical");
        playerdir = new Vector2(0, dirY).normalized;

    }
    void FixedUpdate() {
        rb.velocity = new Vector2(0, playerdir.y * rocketSpeed);
    }
}
