using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
 
public float jumpPower = 10f;
    private Rigidbody2D body;
    private bool isGrounded;
    
void Start() { body = GetComponent<Rigidbody2D>(); }
    
void Update()
    {
        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            body.velocity = new Vector2(body.velocity.x, jumpPower);
            isGrounded = false;
        }
    }
   
void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}
