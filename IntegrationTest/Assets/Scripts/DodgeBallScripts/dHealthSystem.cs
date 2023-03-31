using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class dHealthSystem : MonoBehaviour
{
    public int dodgeHealth = 3;
    public Text dodgeHealthText;
    

    

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "dodgeBall")
        {
            dodgeHealth--;
            dodgeHealthText.text = dodgeHealth.ToString();
            Debug.Log(dodgeHealth);
        }

    }

    private void checkHealth() {
        if (dodgeHealth == 0) {
            
            SceneManager.LoadScene(1);
        }
    }
    
    void Update()
    {
        checkHealth();
    }
}
