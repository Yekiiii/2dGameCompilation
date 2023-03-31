using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dPrevScore : MonoBehaviour
{
    public Text dodgePrevScore;
    // Start is called before the first frame update
    void Start()
    {

        dodgePrevScore.text = PlayerPrefs.GetInt("DodgeScore").ToString() ;
    }

    
}
