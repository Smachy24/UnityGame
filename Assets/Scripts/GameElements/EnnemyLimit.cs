using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyLimit : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ennemy"))
        {

            collision.GetComponent<Ennemy>().Flip();

        }
    }

}
