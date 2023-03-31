using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallBounce : MonoBehaviour
{
    public AudioSource pongBallBounce;
    public BallMovement ballMovement;
    public pongScoreManager scoreManager;
    
    private void Bounce(Collision2D collision)
    {
        Vector3 ballPosition = transform.position;
        Vector3 racketPosition = collision.transform.position;
        float racketHeight = collision.collider.bounds.size.y;
        float posX;
        if (collision.gameObject.name == "PlayerRacket")
        {
            posX = 1;
        }
        else
        {
            posX = -1;
        }
        float posY = (ballPosition.y - racketPosition.y) / racketHeight;
        ballMovement.MoveBall(new Vector2(posX, posY));
        ballMovement.IncHitCount();

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        pongBallBounce.Play();
        if (collision.gameObject.name == "PlayerRacket" || collision.gameObject.name == "OpponentRacket")
        {
            Bounce(collision);
        }
        else if (collision.gameObject.name == "RightBorder")
        {
            scoreManager.playerGoal();
            ballMovement.playerStart = false;
            StartCoroutine(ballMovement.Launch());
        }
        else if (collision.gameObject.name == "LeftBorder") {
            scoreManager.opponentGoal();
            ballMovement.playerStart = true;
            StartCoroutine(ballMovement.Launch());
        }
    }
}
