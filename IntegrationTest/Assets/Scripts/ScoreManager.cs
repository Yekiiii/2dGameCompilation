using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int playerScore = 1;
    public Text playerScoreText;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "UFO")
        {
            playerScore++;
            playerScoreText.text = "Score= "+playerScore.ToString();
            PlayerPrefs.SetInt("SpaceScore",playerScore);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
