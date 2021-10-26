using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpP : MonoBehaviour
{
    Rigidbody2D llantaDelantera;
    public float jumpForce;
    
    bool isjumping;


    void Start()
    {
        llantaDelantera =GetComponent<Rigidbody2D>();
    }

   void Update()
    {
        jump();
    }

    void jump()
    {

        if (Input.GetKeyDown(KeyCode.Space) && !isjumping)
        {
            isjumping = true;
            llantaDelantera.velocity = new Vector2(llantaDelantera.velocity.x, jumpForce);
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isjumping = false;
           
        }
        if (other.gameObject.CompareTag("Obs"))
        {
            isjumping = false;

        }
        if (other.gameObject.CompareTag("Bandera"))
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("Ladrillo"))
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("Cristal"))
        {
            Destroy(other.gameObject);
        }
    }
}