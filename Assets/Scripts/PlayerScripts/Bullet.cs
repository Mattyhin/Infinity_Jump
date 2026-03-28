using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [Range(1f, 10f)]public float speed = 5f;
    public string targetTag = "Enemy";
    
    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(targetTag))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}
