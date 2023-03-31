using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TopDownPrevScore : MonoBehaviour
{
    public Text TopDownPrevScoreText;
    // Start is called before the first frame update
    void Start()
    {

        TopDownPrevScoreText.text = PlayerPrefs.GetInt("topDownPrevScore").ToString();

    }

    
}
