using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
  
    [SerializeField] private float speed;
    [SerializeField] private float jumpPower;

    [Header("Coyote Time")]
    [SerializeField] private float coyoteTime;
    private float coyoteCounter;

    [Header("Multiple Jump")]
    [SerializeField] private int extraJump;
    private int jumpCounter;

    private Rigidbody2D body;
    private Animator anim;
    private bool Grounded;
  
    private void Awake()
    {
        //Grab reference for rigibody and animator from object
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(horizontalInput * speed, body.velocity.y);

        //flip plyer when moving left - right
        if (horizontalInput > 0.01f)
            transform.localScale = Vector3.one;
        else if (horizontalInput < -0.01f)
            transform.localScale = new Vector3 (-1, 1, 1);

        /*if (Input.GetKey(KeyCode.Space)&& Grounded)
        {
            Jump();
        }*/
       
        //Set animator paramiters
        anim.SetBool("Run", horizontalInput != 0);
        anim.SetBool("Grounded", Grounded);
        //Jump
        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            body.velocity = new Vector2(body.velocity.x, jumpPower);
            isGrounded = false;
        }
        /* if (Input.GetKey(KeyCode.Space))
         {
             Jump();
         }
        //Adjustable jump height
         if(Input.GetKeyUp(KeyCode.Space)&& body.velocity.y > 0)
         {
             body.velocity = new Vector2(body.velocity.x, body.velocity.y / 2);
         }



             if (Input.GetKey(KeyCode.Space))
         {
             body.velocity = new Vector2(body.velocity.x, jumpPower);
         }

         if (isGrounded())
         {
             coyoteCounter = coyoteTime;
             jumpCounter = extraJump;
         }
         else
             coyoteCounter -= Time.deltaTime;*/
    }
   
    private bool isGrounded;

    void Start() { body = GetComponent<Rigidbody2D>(); }

   
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }


  

    /*private void Jump()
    {
        if (coyoteCounter < 0 && jumpCounter <= 0) return;
        {
            if(isGrounded())
                body.velocity = new Vector2(body.velocity.x, jumpPower);
                else
                {
                    if(coyoteCounter > 0)
                        body.velocity = new Vector2(body.velocity.x, jumpPower);
                    else
                {
                    if(jumpCounter >0)
                    {
                        body.velocity = new Vector2(body.velocity.x, jumpPower);
                        jumpCounter--;
                    }
                }
                    
                    
            }
            coyoteCounter = 0;
        }
        body.velocity = new Vector2(body.velocity.x, jumpPower);
        anim.SetTrigger("jump");
        Grounded = false;

    }*/

    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
            Grounded = true;
    }

    private bool isGrounded()
    {
        return false;
    }
   
     public float speed = 10;
     public float jump = 5;
     private Rigidbody2D rb2D;
     void Start()
     {
         rb2D = GetComponent<Rigidbody2D>();
     }//Start


     void Update()
     {
         float move = Input.GetAxis("Horizontal");
         rb2D.velocity = new Vector2(move * speed, rb2D.velocity.y);

         if(Input.GetKeyDown(KeyCode.Space))
         {
             rb2D.AddForce(new Vector2(0, jump), ForceMode2D.Impulse);
         }
     }//Update*/

}//PlayerControl
