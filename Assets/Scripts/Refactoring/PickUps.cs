using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUps : MonoBehaviour
{
    private int count;
    private int bombas;

    public int Bombas { get => bombas; set => bombas = value; }

    public int Count { get => count; }

    void Awake()
    {
        count = 0;
        bombas = 0;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Bandera"))
        {
            Destroy(other.gameObject);
            count = Count + 10;
        }
        if (other.gameObject.CompareTag("Ladrillo"))
        {
            Destroy(other.gameObject);
            count = Count + 4;
        }
        if (other.gameObject.CompareTag("Cristal"))
        {
            Destroy(other.gameObject);
            count = Count + 6;
        } 
        if (other.gameObject.CompareTag("BombaPickUp"))
        {
            Destroy(other.gameObject);
            bombas = bombas + 1;
        }
    }
}
