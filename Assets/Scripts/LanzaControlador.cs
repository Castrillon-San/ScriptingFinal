using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class LanzaControlador : MonoBehaviour
{

    protected float moveSpeed = 33f;
    protected Rigidbody2D bala;
    protected IDamage[] targets;
    protected int actualTarget = 0;
    protected Vector2 moveDirection;
    protected int damage = 10;
    void Awake() {
        bala = GetComponent<Rigidbody2D>();
        targets = FindObjectsOfType<MonoBehaviour>().OfType<IDamage>().ToArray();
       
    }
    private void Start()
    {
         if(targets != null)
        {
            moveDirection = (targets[actualTarget].GetTransform().position - transform.position).normalized * moveSpeed;
            Lanzar();
        }
    }

    public virtual void Lanzar()
    {
        bala.velocity = new Vector2(50, 17);
        Destroy(gameObject, 10f);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag(targets[actualTarget].GetTransform().gameObject.tag))
        {
            targets[actualTarget].Damage(damage);
            Destroy(gameObject);
        }
    }
}
