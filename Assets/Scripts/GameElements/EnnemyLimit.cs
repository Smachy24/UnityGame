using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyLimit : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ennemy"))
        {
            
            if (Ennemy.direction == "right")
            {
                Ennemy.direction = "left";
            }
            else if(Ennemy.direction == "left")
            {
                Ennemy.direction = "right";
            }
            Debug.Log(Ennemy.direction);

        }
    }

}
