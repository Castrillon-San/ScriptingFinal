using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorCarro : MonoBehaviour,IDamage, IVehicle
{
    Rigidbody2D carRigidbody;
    public float velocidadmovimiento;
    Vida vida;

    private void Awake()
    {
        carRigidbody = GetComponent<Rigidbody2D>();
        vida = GetComponent<Vida>();
    }
    private void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.D))
        {
            carRigidbody.velocity = new Vector2(velocidadmovimiento, carRigidbody.velocity.y);

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            carRigidbody.velocity = new Vector2(velocidadmovimiento, carRigidbody.velocity.y);
        }
        Vector3 euler = transform.eulerAngles;
        if (euler.z > 180) euler.z = euler.z - 360;
        euler.z = Mathf.Clamp(euler.z, -4, 6);
        transform.eulerAngles = euler;
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Obs"))
        {
            
            carRigidbody.velocity = Vector2.zero;
            velocidadmovimiento = 6;
        }
    }

        void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Obs"))
        {
            velocidadmovimiento = 45;
        }
    }

    public void Damage(int daño)
    {
      
        vida.Damage(daño);
    }


    public Transform GetTransform()
    {
        return this.transform;
    }
}

