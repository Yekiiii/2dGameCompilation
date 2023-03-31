using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AimTimer : MonoBehaviour
{
    private float aimTimerTime = 0;
    public Text aimTimerText;
    public float targetTime = 60;
    private float aimTimerLeft;
    private int aimTimerSeconds;
    public KillScript killScript;
    public int currentAimScore;
    

    
    public void aimCheckTimer() {
        if (aimTimerLeft == 0 || aimTimerLeft<0) {
            PlayerPrefs.SetFloat("CurrentScore", currentAimScore);
            SceneManager.LoadScene(4);
        }
    }
    // Update is called once per frame
    void Update()
    {
        currentAimScore = killScript.aimScorePointer;
        aimTimerTime += Time.deltaTime;
        aimTimerLeft = 60f - aimTimerTime;
        aimTimerSeconds = Mathf.FloorToInt(aimTimerLeft);
        aimTimerText.text = "Time left: " + aimTimerSeconds.ToString();
        aimCheckTimer();
    }
}
