using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Pantallas : MonoBehaviour
{
    public Canvas pantallaIni;
    public Canvas pantallaFin;

    void Start()
    {
        // Referenciamos el canvas con determinado Tag y obtenemos el componente Canvas
        pantallaIni = GameObject.FindGameObjectWithTag("PantallaIni").GetComponent<Canvas>();
        pantallaFin = GameObject.FindGameObjectWithTag("PantallaFin").GetComponent<Canvas>();

        // Asignamos los estados a los metodos
        Estados.evento_inicio += Inicio;
        Estados.evento_muerte += Muerte;
    }
    public void Inicio()
    {
        //Activamos y desactivamos el canvas segun el estado en el que se encuentre
        pantallaFin.enabled = false;
        pantallaIni.enabled = true;
    }

    public void Muerte()
    {
        pantallaFin.enabled = true;
        pantallaIni.enabled = false;
    }
}

