using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OvniController : MonoBehaviour
{
    [SerializeField]
    GameObject lanza2;


    public Rigidbody2D enemigo;
    public static float speed;
    float firerate;
    float nextfire;

    private Transform target;


    void Start()
    {
        target = GameObject.FindGameObjectWithTag("SirMeyer").GetComponent<Transform>();
        firerate = 11f;
        nextfire = Time.time;
        speed = 35;
    }

    // Update is called once per frame

    void Update()
    {

        CheckIfTimeToFire();
        enemigo.velocity = new Vector2(speed, enemigo.velocity.y);

    }
    void CheckIfTimeToFire()
    {

        if (Time.time > nextfire)
        {
            Instantiate(lanza2, transform.position, Quaternion.identity);
            nextfire = Time.time + firerate;
        }
    }
    private void FixedUpdate()
    {
        Vector3 euler = transform.eulerAngles;
        if (euler.z > 180) euler.z = euler.z - 360;
        euler.z = Mathf.Clamp(euler.z, -2, 2);
        transform.eulerAngles = euler;
    }
     
}