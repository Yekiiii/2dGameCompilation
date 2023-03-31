using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAi : MonoBehaviour
{
    public Transform playerTransform;
    public Transform zombieTransform;
    private int movespeed = 5;
    public Rigidbody2D rb;
    public Animator zombieAnim;

    Vector2 playerPos;
    Vector2 moving;
    


    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();

    }
    

    // Update is called once per frame
    void Update()
    {

        zombieTransform.position = Vector2.MoveTowards(zombieTransform.position, playerTransform.position, movespeed * Time.deltaTime);
        playerPos = zombieTransform.position;
        
    
    }
    

    void FixedUpdate() {
        Vector2 lookDir = playerPos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }
}
