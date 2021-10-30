using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Vida : MonoBehaviour
{
                           
                            
    public Image damageImage;                                  
    public float flashSpeed = 3f;                               
    public Color flashColour = new Color(1f, 0f, 0f, 0.1f);     
    Image Barra;
    public static float vida = 100f;                                      
    bool damaged =false;
    private int nextSceneToLoad2;


    void Start()
    {
        Barra = GetComponent<Image>();

        nextSceneToLoad2 = SceneManager.GetActiveScene().buildIndex + 1;

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
            Destroy(gameObject);
        }
    }



    void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.CompareTag("Lanza1"))
        {
            damaged = true;
            BarraControlador.vida -= 18f; 
        }

        if (other.gameObject.CompareTag("Lanza2"))
        {
            damaged = true;
            BarraControlador.vida -= 10f; ;     
        }

        if (other.gameObject.CompareTag("CE"))
        {
            BarraControlador.vida -= 100f; ;
        }
    }
  void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.CompareTag("CE"))
        {
            BarraControlador.vida -= 100f; ;
        }
    }


}