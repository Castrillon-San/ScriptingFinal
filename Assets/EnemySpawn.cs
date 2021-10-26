using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {
    public GameObject ovni;
    public GameObject enemy;
    public Transform enemyPos;
    public Transform ovniPos;
    bool isDestroy;
    

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.CompareTag("SirMeyer"))
        {
            isDestroy = false;
            InvokeRepeating("EnemySpawner", 1f, 100000000000000000000000000000f);
            InvokeRepeating("OvniSpawner", 1f, 100000000000000000000000000000f);

        }
        if (coll.gameObject.CompareTag("SirMeyer"))
        {

           
            Destroy(gameObject, 6F);
        }
        


    }
    void Start ()
    {
        
    }
	void EnemySpawner ()
    {
        Instantiate(enemy, enemyPos.position, enemyPos.rotation);
      
    }

   void OvniSpawner()
    {
        Instantiate(ovni, ovniPos.position, ovniPos.rotation);
    }

   
    void Update () {


        if(enemy.activeInHierarchy == false)
        {
            isDestroy = true;
        }
    }
}
