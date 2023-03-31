using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dodgeScoreSystem : MonoBehaviour
{
    public Text dodgeScoreText;
    public int dodgeScore = 0;

    public void increaseDodgeScore() {
        dodgeScore++;
        dodgeScoreText.text = dodgeScore.ToString();
        PlayerPrefs.SetInt("DodgeScore", dodgeScore);

    }
    
    public void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "dodgeBall")
        {
            dodgeScore++;
            dodgeScoreText.text = dodgeScore.ToString();
            Debug.Log(dodgeScore);
            PlayerPrefs.SetInt("DodgeScore", dodgeScore);
        }
        
    }

    
}
