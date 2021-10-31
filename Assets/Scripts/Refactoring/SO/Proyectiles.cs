using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ="CrearPool",menuName ="Pool")]
public class Proyectiles : ScriptableObject
{

    public List<GameObject> pooledObjects;
    public GameObject objectToPool;
    public int amountToPool;
    


    public void CrearLista()
    {
        
        
            pooledObjects = new List<GameObject>();
            GameObject tmp;
            for (int i = 0; i < amountToPool; i++)
            {
                tmp = Instantiate(objectToPool);
                tmp.SetActive(false);
                pooledObjects.Add(tmp);
            }
            
        

    }
    public GameObject GetPooledObject()
    {
        for (int i = 0; i < amountToPool; i++)
        {
            if (!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects[i];
            }
        }
        return null;
    }
}
