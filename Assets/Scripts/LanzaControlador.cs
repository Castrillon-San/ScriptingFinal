using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanzaControlador : MonoBehaviour {
 
    float moveSpeed = 33f;
    Rigidbody2D bala;
    ControladorCarro target;
    Vector2 moveDirection;
    void Start() {
        bala = GetComponent<Rigidbody2D>();
        target = GameObject.FindObjectOfType<ControladorCarro>();
        moveDirection = (target.transform.position - transform.position).normalized * moveSpeed;
        bala.velocity = new Vector2(50, 17);    
        Destroy(gameObject, 10f);
    }

    // Update is called once per frame
    void Update () {
        
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("SirMeyer"))
        {
            Destroy(gameObject);
            

        }
    }
}
