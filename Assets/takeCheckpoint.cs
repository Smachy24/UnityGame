using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class takeCheckpoint : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform playerSpawn;

    private void Awake()
    {
        playerSpawn = GameObject.FindGameObjectWithTag("playerSpawn").transform;
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerSpawn.position = transform.position;
            Destroy(gameObject);
        }
    }
}
