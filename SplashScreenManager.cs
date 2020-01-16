using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreenManager : MonoBehaviour
{
    //Script pour faire un splashscreen

    public float seconds;
    public string scene;

   
    void Start()
    {
        StartCoroutine(SwitchScene());
    }

    IEnumerator SwitchScene()
    {

        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene(scene);
        //Do the thing
    }

}
