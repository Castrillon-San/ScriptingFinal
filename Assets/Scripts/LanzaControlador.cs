using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanzaControlador : MonoBehaviour {
 
    protected float moveSpeed = 33f;
    protected Rigidbody2D bala;
    protected ControladorCarro target;
    protected Vector2 moveDirection;
    void Start() {
        bala = GetComponent<Rigidbody2D>();
        target = GameObject.FindObjectOfType<ControladorCarro>();
        Lanzar();
    }

    public virtual void Lanzar()
    {
        moveDirection = (target.transform.position - transform.position).normalized * moveSpeed;
        bala.velocity = new Vector2(50, 17);
        Destroy(gameObject, 10f);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("SirMeyer"))
        {
            Destroy(gameObject);
        }
    }
}
