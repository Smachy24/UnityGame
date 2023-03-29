using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isInTrap : MonoBehaviour
{
    private Transform playSpawn;


    private void Awake()
    {
        playSpawn = GameObject.FindGameObjectWithTag("playerSpawn").transform;
    }

    // Update is called once per frame

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.transform.position = playSpawn.position;
        }
    }
}
