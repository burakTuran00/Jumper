using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Rigidbody2D rb;

    public float speed;
    public float jumpPower;
    public bool karakteryerde;
    public string name = "Burak";

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();    
    }

   
    private void FixedUpdate()
    {
        float hor = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(hor * speed, rb.velocity.y);

        if (Input.GetKey(KeyCode.Space) && karakteryerde == true)
        {
            Jump();
        }
    }


    void Jump()
    {
        rb.AddForce(Vector2.up * jumpPower *100);
        karakteryerde = false; 
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("zemin"))
        {
            karakteryerde = true;
        }

    }

    
}
