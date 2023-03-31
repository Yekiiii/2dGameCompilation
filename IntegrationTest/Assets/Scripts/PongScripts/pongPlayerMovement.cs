using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pongPlayerMovement : MonoBehaviour
{
    public float racketSpeed;
    private Rigidbody2D rb;
    private Vector2 racketDir;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float direction = Input.GetAxisRaw("Vertical");

        racketDir = new Vector2(0, direction).normalized;
    }
    private void FixedUpdate()
    {
        rb.velocity = racketDir * racketSpeed;
    }
}
