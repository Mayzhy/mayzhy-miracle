using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterSeconds : MonoBehaviour
{
    //Objet ce detruit après quelque secondes 

    public float seconds;

   
    void Start()
    {
        GameObject.Destroy(this.gameObject, seconds);
    }

    
}