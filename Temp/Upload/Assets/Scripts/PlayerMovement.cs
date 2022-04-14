using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int speed;
    private float Move;

    private Rigidbody2D rb;
    public float Jump;
    public bool IsJumping;


    // Update is called once per frame
    void Update()
    {
        rb = GetComponent<Rigidbody2D>();
        Move = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(speed * Move, rb.velocity.y);

        if (Input.GetButtonDown("Jump") && IsJumping == false)
        {

            rb.AddForce(new Vector2(rb.velocity.x, Jump));
        }
    }
    //Allows character to jump
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            IsJumping = false;
        }
    }

    //
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            IsJumping = true;
        }
    }
}