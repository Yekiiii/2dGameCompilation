using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoringSystem : MonoBehaviour
{
    
    

    public int dodgeScore = 0;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("dodgeBall"))
        {
            dodgeScore++;
            Debug.Log(dodgeScore);
        }
    }
    
}
