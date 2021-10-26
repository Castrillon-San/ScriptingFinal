using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverController : MonoBehaviour {


    public float Reinicio = 5f;         
    public float GameOver = 2f;                                 
    float restartTimer;                     
    bool muerte = false;
    public bool isImg;
    public Image img2;
    public bool isImgOn;
    public Image img;

    void Start()
    {
        img.enabled = false;
        isImgOn = false;
        img2.enabled = false;
        isImg = false;
    }


    void FixedUpdate ()
    {
        
        if (BarraControlador.vida <= 0f)
        {
            

            
            restartTimer += Time.deltaTime;

           
            if (restartTimer >= GameOver)
            {
                

                if (isImgOn == false)
                {

                    img.enabled = true;
                    isImgOn = true;
                }



                if (isImg == false)
                {

                    img2.enabled = true;
                    isImg = true;
                }
            }
        
            if (restartTimer >= Reinicio)
            {
                Application.LoadLevel(Application.loadedLevel);
            }
        }
      
    }
}
