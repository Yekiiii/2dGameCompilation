using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dScoreSystemRight : MonoBehaviour
{
    public dodgeScoreSystem dscoreleft;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "dodgeBall")
        {
            dscoreleft.increaseDodgeScore();
        }

    }
}
