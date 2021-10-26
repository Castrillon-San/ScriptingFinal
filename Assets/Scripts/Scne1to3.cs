using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scne1to3 : MonoBehaviour {

  
    private int nextSceneToLoad;
    private void Start()
    {
        // Only specifying the sceneName or sceneBuildIndex will load the Scene with the Single mode
        nextSceneToLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("salida"))
        {
            SceneManager.LoadScene(nextSceneToLoad);
        }


    }
}

