using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Daño : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("SirMeyer"))
        {
            Destroy(gameObject);
            BarraControlador.vida -= 6f;
           
        }
    }
       
    }

