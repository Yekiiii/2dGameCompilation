using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pongScoreManager : MonoBehaviour
{
    public int finalScore;
    private int playerScore = 0;
    private int opponentScore = 0;
    public Text playerScoreText;
    public Text opponentScoreText;

    public void playerGoal() {
        playerScore++;
        playerScoreText.text = playerScore.ToString();
        CheckScore();
    }
    public void opponentGoal() {
        opponentScore++;
        opponentScoreText.text = opponentScore.ToString();
        CheckScore();
    }
    public void CheckScore() {
        if (playerScore == finalScore || opponentScore == finalScore) {
            SceneManager.LoadScene(3);
        }
    }
}
