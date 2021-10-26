using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombaController : MonoBehaviour 
{

    float moveSpeed = 31f;
    Rigidbody2D bala;
    ControladorEnemigo target;
    Vector2 moveDirection;
    void Start()
    {
        bala = GetComponent<Rigidbody2D>();
        
        bala.velocity = new Vector2(-15, 5); 
        Destroy(gameObject, 3f);
    }



    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("CE")) 
        {
          
            Destroy(gameObject);
        }
    }

}