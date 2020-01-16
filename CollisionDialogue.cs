using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDialogue : MonoBehaviour
{
    //Quand tu collide permet d'afficher un dialogue, objet ou autre

    public GameObject Texte;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.tag == "Player")
        {
            Texte.SetActive(true);
        }
    }
}
