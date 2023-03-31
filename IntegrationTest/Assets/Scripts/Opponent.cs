using UnityEngine;
using System.Collections;

public class Opponent: MonoBehaviour
{
    public Transform target;
    public float speed;

    private void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector2.MoveTowards(transform.position, new Vector2(transform.position.x, target.position.y), step);
    }

}