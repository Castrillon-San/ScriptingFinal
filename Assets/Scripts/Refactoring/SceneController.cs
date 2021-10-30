using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    private int nextSceneToLoad1;
    bool Salida = false;

    void Start()
    {
        nextSceneToLoad1 = SceneManager.GetActiveScene().buildIndex + 1;
    }

    void Update()
    {
        if (Salida == true)
        {
            SceneManager.LoadScene(nextSceneToLoad1);
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("salida"))
        {
            Salida = true;
        }
    }
}
