using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieHealth : MonoBehaviour
{
    private int health = 3;
    public Shooting shooting;
    public AudioSource zombieBulletCollideAudio;
    
    public void OnCollisionEnter2D(Collision2D collision) {
        if (collision.collider.tag == "Bullet") {
            health--;
            Debug.Log(health);
            zombieBulletCollideAudio.Play();
        }
        if (health == 0) {
            shooting.BulletRefill();
            Destroy(this.gameObject);
            zombieBulletCollideAudio.Play();
        }
    }
    
}
