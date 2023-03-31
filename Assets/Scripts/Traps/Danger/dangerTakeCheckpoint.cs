using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dangerTakeCheckpoint : MonoBehaviour
{
    private Transform dangerSpawn;
    private Transform playerSpawn;

    private void Awake()
    {
        dangerSpawn = GameObject.FindGameObjectWithTag("dangerSpawn").transform;
        playerSpawn = GameObject.FindGameObjectWithTag("playerSpawn").transform;
    }

    // Update is called once per frame

    private void takeCheckpoint()
    {
        if (playerSpawn.position.y > transform.position.y)
        {
            dangerSpawn.position = transform.position;
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Danger"))
        {
            takeCheckpoint();   
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Danger"))
        {
            takeCheckpoint();
        }
    }
}
