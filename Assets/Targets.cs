using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Targets : MonoBehaviour
{
    public IVehicle[] targets;

    void Awake()
    {
        targets = FindObjectsOfType<MonoBehaviour>().OfType<IVehicle>().ToArray();
    }

}
