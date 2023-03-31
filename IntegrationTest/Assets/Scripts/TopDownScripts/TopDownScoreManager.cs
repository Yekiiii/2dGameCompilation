using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TopDownScoreManager : MonoBehaviour
{
    private static int topDownScore = 0;
    public Text topDownScoreText;
    public int topDownScoreNS;

    
    private void OnDestroy() {
        topDownScore++; 
    }
    private void Update() {
        topDownScoreNS = topDownScore;
        PlayerPrefs.SetInt("topDownPrevScore", topDownScoreNS);
        topDownScoreText.text = topDownScore.ToString();
    }
    
}
