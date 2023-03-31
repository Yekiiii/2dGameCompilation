using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    private int health = 10;
    public Text playerHealthText;
    public AudioSource zombieCollisionAudio;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnCollisionEnter2D(Collision2D collision) {
        if (collision.collider.tag == "Zombie") {
            health--;
            Debug.Log(health);
            zombieCollisionAudio.Play();

            
        }
        if (health == 0) {
            SceneManager.LoadScene(5);
        }
    }


    // Update is called once per frame
    void Update()
    {
        playerHealthText.text = "Player Health: "+health.ToString();
    }
}
