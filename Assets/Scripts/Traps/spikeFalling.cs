using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikeFalling : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] Collider2D collidero;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            rb.bodyType = RigidbodyType2D.Dynamic;
            rb.gravityScale = 5f;
            Destroy(gameObject, 1.5f);
        }
    }
}
