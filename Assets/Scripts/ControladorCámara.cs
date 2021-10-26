using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorCámara : MonoBehaviour {

    //define player game object
    public GameObject player;

    //wait for lateupdate
    void LateUpdate()
    {
        if(player.gameObject != null)
        {
            transform.position = new Vector3(player.transform.position.x, 10f, -10f);

        }
    }
}