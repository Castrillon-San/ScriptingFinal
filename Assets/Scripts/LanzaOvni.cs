using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanzaOvni : LanzaControlador
{
    public LanzaOvni() : base()
    {
        damage = 30;
    }
    public override void Lanzar()
    {
        bala.velocity = new Vector2(70, 6); 
        Destroy(gameObject, 10f);
    }
}