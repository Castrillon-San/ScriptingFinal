using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanzaOvni : LanzaControlador
{

    public override void Lanzar()
    {
        
        moveDirection = (target.transform.position - transform.position).normalized * moveSpeed;
        bala.velocity = new Vector2(70, 6); 
        Destroy(gameObject, 10f);
    }
}