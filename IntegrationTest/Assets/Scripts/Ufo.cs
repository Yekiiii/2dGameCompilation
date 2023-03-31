using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ufo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag == "Border" || collision.tag=="Player") {
            Destroy(this.gameObject);
        }
    }
    
    // Update is called once per frame

}
