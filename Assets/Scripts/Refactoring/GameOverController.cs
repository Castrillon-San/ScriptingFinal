using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverController : MonoBehaviour {

    void Start()
    {
        //llamamos el evento
        Estados.evento_inicio();
    }
    void FixedUpdate ()
    {
        
        if (BarraControlador.vida <= 0f)
        {
            // igualmente se llama el evento despues de una condicion
            Estados.evento_muerte();
        }
      
    }
}
