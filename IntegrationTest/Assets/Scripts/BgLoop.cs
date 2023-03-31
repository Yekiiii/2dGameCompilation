using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgLoop : MonoBehaviour
{
    private float backgroundSpeed = 1;
    public Renderer bgRenderer;
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        bgRenderer.material.mainTextureOffset += new Vector2(backgroundSpeed * Time.deltaTime, 0f);
    }
}
