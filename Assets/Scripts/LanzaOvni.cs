using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanzaOvni : MonoBehaviour
{

    float moveSpeed = 35;
    Rigidbody2D bala2;
    ControladorCarro target;
    Vector2 moveDirection;
    void Start()
    {
        bala2 = GetComponent<Rigidbody2D>();
        target = GameObject.FindObjectOfType<ControladorCarro>();
        moveDirection = (target.transform.position - transform.position).normalized * moveSpeed;
        bala2.velocity = new Vector2(70, 6); 
        Destroy(gameObject, 10f);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("SirMeyer"))
        {
            Destroy(gameObject);
            

        }
    }
}