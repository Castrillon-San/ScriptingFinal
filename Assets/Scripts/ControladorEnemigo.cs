using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControladorEnemigo : MonoBehaviour
{
    [SerializeField]
    GameObject lanza;
    float firerate;
    float nextfire;
    public float jumpForce;
    public Rigidbody2D enemigo;
    public Rigidbody2D llantaTrasera;
    public Rigidbody2D llantaDelantera;
    public float speed;
    private Transform target;
    bool parar;


    void Start()
    {
        target = GameObject.FindGameObjectWithTag("SirMeyer").GetComponent<Transform>();
        firerate = 2.8f;
        nextfire = Time.time;
    }



    void Update()
    {

        CheckIfTimeToFire();
        enemigo.velocity = new Vector2(speed, enemigo.velocity.y);

       

    }
    void CheckIfTimeToFire()
    {

        if (Time.time > nextfire && target.gameObject.activeSelf != false)
        {
            Instantiate(lanza, transform.position, Quaternion.identity);
            nextfire = Time.time + firerate;
        }
    }
    private void FixedUpdate()
    { Vector3 euler = transform.eulerAngles;
        if (euler.z > 180) euler.z = euler.z - 360;
        euler.z = Mathf.Clamp(euler.z, -2, 2);
        transform.eulerAngles = euler;
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Obs"))
        {
            enemigo.velocity = new Vector2(enemigo.velocity.x, jumpForce);
            speed = 40;
            OvniController.speed = 38;
        }
        if (other.gameObject.CompareTag("bomba")) 
        {
            parar = true;
            Destroy(other.gameObject);
            speed = 23;
            OvniController.speed = 23;
        }
       


    }
   
   
}

   

