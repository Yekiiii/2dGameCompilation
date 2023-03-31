using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class aimCurrentScore : MonoBehaviour
{
    public Text aimCurrentScoreText;

    
    void Start()
    {
        aimCurrentScoreText.text = PlayerPrefs.GetFloat("CurrentScore").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
