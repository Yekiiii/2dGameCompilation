using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class runnerCamera : MonoBehaviour
{
    public float initcamspeed = 5;
    public int increaseInSpeed;
    private float camspeed;
    ScoreManager sM;
    public GameObject obj;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Awake()
    {
        sM = obj.GetComponent<ScoreManager>();

    }
    void checkScore()
    {
        increaseInSpeed = sM.playerScore / 10;
        Debug.Log(increaseInSpeed);
    }
    // Update is called once per frame
    void Update()

    {
        checkScore();
        camspeed = initcamspeed + increaseInSpeed;
        transform.position += new Vector3(camspeed * Time.deltaTime, 0, 0);
    }
}
