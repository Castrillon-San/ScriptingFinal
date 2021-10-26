using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Manager : MonoBehaviour
{

    // Use this for initialization


    private int nextSceneToLoad;
    private void Start()
    {
        // Only specifying the sceneName or sceneBuildIndex will load the Scene with the Single mode
        nextSceneToLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }
    void Update()
    {

        //if press any key jump to gameplay scene
        if (Input.anyKeyDown)
        {
            SceneManager.LoadScene(nextSceneToLoad);
        }
    }
}

