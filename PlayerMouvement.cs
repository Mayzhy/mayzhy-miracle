using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMouvement : MonoBehaviour
{
    //Mouvement du player

    public float speed;
    
   
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        if (horizontal > 0.1 || horizontal < -0.1)
        {
            vertical = 0;
        }

        Vector3 moveDirection = new Vector3(horizontal, vertical, 0);
        moveDirection *= speed * Time.deltaTime;

        Vector3 poition = transform.position;
        transform.position += moveDirection;



    }
}
