using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillScript : MonoBehaviour
{
    // Start is called before the first frame update
    
    private Rigidbody2D rb;
    
    public static int aimScore = 0;
    public Text aimScoreText;
    public Transform whiteTargetTransform;
    public int aimScorePointer;
    public AudioSource whiteTargetDestroyAudio;



    public void decreaseAimScore() {
        aimScore--;
        
        aimScoreText.text = "Score = " + aimScore;
    }
    public void increaseAimScore() {
        aimScore++;
        
        aimScoreText.text = "Score = " + aimScore;
    }
    IEnumerator WhiteSelfDestruct()
    {
        if (whiteTargetTransform.position.x > -10)
        {
            yield return new WaitForSeconds(2f);
            decreaseAimScore();
            Destroy(gameObject);
        }
        
    }
    void Start()
    {
        StartCoroutine(WhiteSelfDestruct());
        rb = GetComponent<Rigidbody2D>();
        
    }
    void Update() {

        aimScorePointer = aimScore;
    }
    
    

    void OnMouseDown()  {
        increaseAimScore();
        whiteTargetDestroyAudio.Play();
        Destroy(gameObject);
        
        
    }
    
    
        
        
    
    
}
