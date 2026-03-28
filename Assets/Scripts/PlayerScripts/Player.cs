using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Range(0f, 6f)]public float speed = 3f;
    [Range(1f, 10f)]public float jumpForce = 3.75f;
    [Range(1f, 3f)]public float trampolineMultiplier = 1.3f;
    
    public Rigidbody2D rb;
    public FixedJoystick joystick;
    
    private void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }

        if (joystick.Horizontal != 0)
        {
            transform.Translate(Vector2.right * joystick.Horizontal * speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (rb.velocity.y > 0)
            return;
        switch (collision.gameObject.tag)
        {
            case "Platform":
                rb.velocity = Vector2.up * jumpForce;
                break;
            case "DestroyablePlatform":
                rb.velocity = Vector2.zero;
                Destroy(collision.gameObject);
                break;
            case "OneJumpPlatform":
                rb.velocity = Vector2.up * jumpForce;
                Destroy(collision.gameObject);
                break;
            case "TrampolinePlatform":
                rb.velocity = Vector2.up * jumpForce * trampolineMultiplier;
                break;
        }
    }
}
