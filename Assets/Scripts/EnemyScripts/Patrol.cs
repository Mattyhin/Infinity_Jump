using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public float speed = 3f;
    public bool goLeft = true;

    public Transform left;
    public Transform right;
    
    void Update()
    {
        if (goLeft)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }

        if (transform.position.x < left.position.x)
        {
            goLeft = false;
        }
        else if (transform.position.x > right.position.x)
        {
            goLeft = true;
        }
    }
}
