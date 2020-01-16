using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManagerScript : MonoBehaviour
{
    //permet de faire une scène qui met en pause le jeu

    bool paused = false;
    public KeyCode pauseButton = KeyCode.Clear;
    public string pauseScene;

   
    void Update()
    {
        if (Input.GetKeyDown(pauseButton))
        {
            if (paused)
            {
                paused = false;
                Time.timeScale = 1;
                SceneManager.UnloadSceneAsync(pauseScene);

            }
            else
            {
                paused = true;
                Time.timeScale = 0;
                SceneManager.LoadScene(pauseScene, LoadSceneMode.Additive);
            }
        }
    }
}




