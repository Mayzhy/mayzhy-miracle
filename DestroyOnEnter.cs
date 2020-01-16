using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnEnter : MonoBehaviour
{
    
    //Detruit un objet quand tu passe dessus

    public void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject.Destroy(this.gameObject);
    }


}
