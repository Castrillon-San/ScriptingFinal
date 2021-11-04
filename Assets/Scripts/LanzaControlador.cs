using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanzaControlador : MonoBehaviour
{

    protected float moveSpeed = 1.5f;
    protected Rigidbody2D bala;
    protected Targets vehicles;
    protected int actualTarget = 0;
    protected Vector2 moveDirection;
    protected int damage = 10;
    protected IDamage enemigo;
    void Awake() {

        bala = GetComponent<Rigidbody2D>();
        vehicles = FindObjectOfType<Targets>();
    }
    private void Start()
    {
         if(vehicles.targets != null)
         {
            moveDirection = (vehicles.targets[actualTarget].GetTransform().position - transform.position).normalized * moveSpeed;
            Lanzar();
         }
    }
  

    public virtual void Lanzar()
    {

        bala.velocity = new Vector2(50, 20)*moveDirection;
        actualTarget = Random.Range(0, vehicles.targets.Length-1);
        StartCoroutine("DesactivarP");
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag(vehicles.targets[actualTarget].GetTransform().gameObject.tag))
        {
            
            enemigo = other.gameObject.GetComponent<IDamage>();

            if (enemigo != null)
            {
                enemigo.Damage(damage);
                enemigo = null;
            }
            
            gameObject.SetActive(false);
        }
    }
    IEnumerator DesactivarP()
    {
        yield return new WaitForSeconds(10f);
        gameObject.SetActive(false);
    }
}
