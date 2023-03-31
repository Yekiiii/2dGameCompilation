using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpacePrevScore : MonoBehaviour
{
    public Text spacePrevScoreText;
    // Start is called before the first frame update
    void Start()
    {
        spacePrevScoreText.text = PlayerPrefs.GetInt("SpaceScore").ToString();
    }

    
}
