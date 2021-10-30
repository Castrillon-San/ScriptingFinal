using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Vida : MonoBehaviour, IDamage
{
                           
                            
    public Image damageImage;                                  
    public float flashSpeed = 3f;                               
    public Color flashColour = new Color(1f, 0f, 0f, 0.1f);     
    Image Barra;
    public static float vida = 100f;                                      
    bool damaged =false;


    void Start()
    {
        Barra = GetComponent<Image>();
    }

    public void Damage(int daño)
    {
        damaged = true;
        BarraControlador.vida -= daño; 
    }
    public Transform GetTransform()
    {
        return this.transform;
    }
     void Update()
    {
        
        if (damaged == true)
        {
            // ... set the colour of the damageImage to the flash colour.
            damageImage.color = flashColour;

        }
        // Otherwise...
        else
        {
            // ... transition the colour back to clear.
            damageImage.color = Color.Lerp(damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
        }

        damaged = false;


        if (BarraControlador.vida <= 0f)
        {
            this.gameObject.SetActive(false);
        }
    }



    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("CE"))
        {
            BarraControlador.vida -= 100f; ;
        }
    }
  void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.CompareTag("CE"))
        {
            BarraControlador.vida -= 100f;
        }
    }
}