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
        bala.velocity = new Vector2(75, 3)* moveDirection;
        StartCoroutine("DesactivarP");
    }
    IEnumerator DesactivarP()
    {
        yield return new WaitForSeconds(10f);
        gameObject.SetActive(false);
    }
}