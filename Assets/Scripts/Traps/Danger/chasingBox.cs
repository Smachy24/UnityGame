using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chasingBox : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Transform wrapperBox;
    [SerializeField] float speed = 1.5f;
    // Update is called once per frame

    private Transform dangerSpawn;

    private void Awake()
    {
        dangerSpawn = GameObject.FindGameObjectWithTag("dangerSpawn").transform;
    }
    void Update()
    {
     wrapperBox.Translate(Vector2.up * speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            wrapperBox.position = dangerSpawn.position;
        }
    }

}
