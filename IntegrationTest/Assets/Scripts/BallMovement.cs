using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{

    public float startSpeed;
    public float progSpeed;
    public float maxSpeed;
    private int hitCount = 0;
    private Rigidbody2D rb;
    public bool playerStart = true;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine(Launch());
    }
    private void restart() {
        rb.velocity = new Vector2(0, 0);
        transform.position = new Vector2(0, 0);
    
    }

    // Update is called once per frame
    public void MoveBall(Vector2 direction)
    {
        direction = direction.normalized;
        float ballSpeed = startSpeed + hitCount * progSpeed;
        rb.velocity = direction * ballSpeed;
    }
    public IEnumerator Launch() {
        restart();
        hitCount = 0;
        yield return new WaitForSeconds(1);
        MoveBall(new Vector2(-1, 0));
        if (playerStart == true) {
            MoveBall(new Vector2(-1, 0));

        }
        else
        {
            MoveBall(new Vector2(1, 0));

        }
    }
    public void IncHitCount() {
        if (hitCount * progSpeed < maxSpeed) {
            hitCount++;
        }
    }
}
