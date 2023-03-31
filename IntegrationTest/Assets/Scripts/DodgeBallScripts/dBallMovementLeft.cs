using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dBallMovementLeft : MonoBehaviour
{
    private Rigidbody2D rb;
    public int speed = 2;






    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "dodgeBallDestroyer")
        {
            Destroy(this.gameObject);
        }
        if (collision.collider.tag == "dodgePlayer")
        {
            Destroy(this.gameObject);
        }

    }
    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;
    }
}
