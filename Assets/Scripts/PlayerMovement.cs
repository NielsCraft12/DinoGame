using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    public float jumpingPower;
    public Sprite sp1, sp2;
    

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    
    void Update()
    {
        
        if(Input.GetButtonDown("Jump")&& IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
            
        }

        if(Input.GetButtonUp("Jump")&& rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
            GetComponent<SpriteRenderer>().sprite = sp2;
        }

        if(IsGrounded() == true) 
        {
            GetComponent<SpriteRenderer>().sprite = sp1;
        }

        if (IsGrounded() == false)
        {
            GetComponent<SpriteRenderer>().sprite = sp2;
        }

    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    
}
