using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public AudioSource ufoCollide;
    public AudioSource buffCollide;
    public int health = 3;
    public Text playerHealthText;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "UFO")
            
        {
            ufoCollide.Play();
            health--;
            playerHealthText.text = "Health = "+health.ToString();
        }
        if (health == 0) {
            SceneManager.LoadScene(2);
        }

        else if (collision.tag == "Buff")
        {
            buffCollide.Play();
            if (health ==1) 
            {
                health = 3 ;
                playerHealthText.text = "Health = " + health.ToString();
            }
            if (health == 2) {
                health = 3;
                playerHealthText.text = "Health = " + health.ToString();
            }
                
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
