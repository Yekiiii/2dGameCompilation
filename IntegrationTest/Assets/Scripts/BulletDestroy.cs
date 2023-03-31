using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnCollisionEnter2D(Collision2D collision) {
        Destroy(this.gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
