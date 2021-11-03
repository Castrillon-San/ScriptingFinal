using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class LanzaControlador : MonoBehaviour
{

    protected float moveSpeed = 1.5f;
    protected Rigidbody2D bala;
    protected IVehicle[] targets;
    protected int actualTarget = 0;
    protected Vector2 moveDirection;
    protected int damage = 10;
    protected IDamage enemigo;
    void Awake() {
        bala = GetComponent<Rigidbody2D>();
        targets = FindObjectsOfType<MonoBehaviour>().OfType<IVehicle>().ToArray();
       
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

        bala.velocity = new Vector2(50, 20)*moveDirection;
        actualTarget = Random.Range(0, targets.Length-1);
        StartCoroutine("DesactivarP");
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag(targets[actualTarget].GetTransform().gameObject.tag))
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
