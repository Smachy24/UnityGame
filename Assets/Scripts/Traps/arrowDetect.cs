using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowDetect : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Ground") || collision.gameObject.layer == LayerMask.NameToLayer("Traps"))
        {
            Destroy(gameObject);
        }
        
    }

}
