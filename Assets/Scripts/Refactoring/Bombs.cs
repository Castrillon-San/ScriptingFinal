using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bombs : MonoBehaviour
{
    private float coolDownTimer;
    public float coolDown = 1;
    PickUps pickups;
    [SerializeField] GameObject bombalanzamiento;

    void Awake()
    {
        pickups = GetComponent<PickUps>();
    }

    void Update()
    {
        if (coolDownTimer > 0)
        {
            coolDownTimer -= Time.deltaTime;
        }
        if (coolDownTimer < 0)
        {
            coolDownTimer = 0;
        }
        if (pickups.Bombas >= 1 && coolDownTimer == 0)
        {
            if (Input.GetKey(KeyCode.E))
            {
                coolDownTimer = coolDown;
                Instantiate(bombalanzamiento, transform.position, Quaternion.identity);
                pickups.Bombas = pickups.Bombas - 1;
            }

        }
    }
}
