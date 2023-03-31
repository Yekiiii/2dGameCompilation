using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillScriptGreen : MonoBehaviour
{
    public KillScript killScript;
     private Rigidbody2D rb;
    public Transform greenTargetTransform;
    public AudioSource greenTargetDestroyAudio;
    

    void Start()
    {
        StartCoroutine(GreenSelfDestruct());
        rb = GetComponent<Rigidbody2D>();

    }

    IEnumerator GreenSelfDestruct() {
        if (greenTargetTransform.position.x > -10)
        {
            yield return new WaitForSeconds(3f);
            killScript.decreaseAimScore();
            Destroy(gameObject);
        }

    }

    void OnMouseDown()
    {
        greenTargetDestroyAudio.Play();
        Destroy(gameObject);
        killScript.increaseAimScore();
    }
    


}
