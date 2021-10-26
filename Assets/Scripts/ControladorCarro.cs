using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControladorCarro : MonoBehaviour
{
    [SerializeField]
    GameObject bombalanzamiento;
    public float coolDown = 1;
    private float coolDownTimer;
    private Transform target;
    bool Salida = false;
    private int nextSceneToLoad1;
    public Rigidbody2D carRigidbody;
    public Rigidbody2D llantaTrasera;
    public Rigidbody2D llantaDelantera;
    public float velocidadmovimiento;
    private int count;
    public Text countText;
    private int bombas;
    public Text bombasText;

    private void Start()
    {
        count = 0;
        bombas = 0;
        SetCountText();
        nextSceneToLoad1 = SceneManager.GetActiveScene().buildIndex + 1;
        
    }


    void Update()
    {

        if( Salida== true)
        {
            SceneManager.LoadScene(nextSceneToLoad1);
        }
        if (coolDownTimer > 0)
        {
            coolDownTimer -= Time.deltaTime;
        }
        if (coolDownTimer < 0)
        {
            coolDownTimer = 0;
        }

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
        if (BarraControlador.vida <= 0f)
        {
            Destroy(gameObject);
        }
        if (bombas >= 1 && coolDownTimer == 0)
        {
            if (Input.GetKey(KeyCode.E))
            {
                coolDownTimer = coolDown;
                Instantiate(bombalanzamiento, transform.position, Quaternion.identity);
                bombas = bombas - 1;
                SetCountText();
            }

        }

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Obs"))
        {
            
            carRigidbody.velocity = Vector2.zero;
            velocidadmovimiento = 6;
        }
        if (other.gameObject.CompareTag("Bandera"))
        {
            Destroy(other.gameObject);
            count = count + 10;
            SetCountText();
        }
        if (other.gameObject.CompareTag("Ladrillo"))
        {
            Destroy(other.gameObject);
            count = count + 4;
            SetCountText();
        }
        if (other.gameObject.CompareTag("Cristal"))
        {
            Destroy(other.gameObject);
            count = count + 6;
            SetCountText();
        }
        if (other.gameObject.CompareTag("salida"))
        {

            Salida = true;
        }
        

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("BombaPickUp"))
        {
            Destroy(other.gameObject);
            bombas = bombas + 1;
            SetCountText();
        }

    }


        void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Obs"))
        {
            velocidadmovimiento = 45;
        }

    }
    void SetCountText()
    {
        countText.text = "Materiales: " + count.ToString();
        bombasText.text = "" + bombas.ToString();
    }
}

