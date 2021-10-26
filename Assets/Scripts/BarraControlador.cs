using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BarraControlador : MonoBehaviour {

    Image Barra;
    float maxHealth =100f;
    public static float vida;
	void Start () {
        Barra = GetComponent<Image>();
        vida = maxHealth;
    }
	
	void Update () {
        Barra.fillAmount = vida / maxHealth;
	}
}
