using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dPlayerMovement : MonoBehaviour
{

    public int speed = 5;
    private float movementX;
    private float movementY;
    public Rigidbody2D myBody;
    public Animator anim;
    public float moveForce = 10f;
    public float jumpForce = 11f;
    public SpriteRenderer sr;
    private string WALK_ANIMATION = "Walk";
    private string JUMP_ANIMATION = "Jump";
    public bool onGround = true;
    private string groundtag = "Ground";

    void MovementPlayer() {
        movementX = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector2 pos = transform.position;
        transform.position += new Vector3(movementX, 0f, 0f) * Time.deltaTime * moveForce;
        pos.y += v * speed * Time.deltaTime;

    }
    void AnimatePlayer()
    {
        if (movementX > 0)
        {
            anim.SetBool(WALK_ANIMATION, true);
            sr.flipX = false;
        }
        else if (movementX < 0)
        {
            anim.SetBool(WALK_ANIMATION, true);
            sr.flipX = true;
        }
        else {
            anim.SetBool(WALK_ANIMATION, false);
        }
        

        

        

    }

    void jumpAnim() {
        if (onGround == false)
        {
            anim.SetBool(JUMP_ANIMATION, true);
        }
        else {
            anim.SetBool(JUMP_ANIMATION, false);
        }
    }

    void PlayerJump()
    {
        if (Input.GetButtonDown("Jump")&& onGround)
        {
            onGround = false;
            Debug.Log("Cannot Jump");
            myBody.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            
        }
    }
    // Update is called once per frame
    void Update()
    {
        MovementPlayer();
        AnimatePlayer();
        jumpAnim();
    }
    private void FixedUpdate() {
        PlayerJump();
    }
    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.CompareTag(groundtag)) {
            onGround = true;
            Debug.Log("Can Jump");
        }
    }
    
}
