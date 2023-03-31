using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    private float moveSpeed = 5f;
    
    public Rigidbody2D rb;
    
    public Camera cam;

    Vector2 mousePos;
    Vector2 movement;


    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D rb = GetComponent <Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);


    }
    void FixedUpdate() 
    {
        rb.velocity = movement*moveSpeed;
        Vector2 lookDirection = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }
}
