using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFireBall : MonoBehaviour
{

    //[SerializeField]
    private GameObject _player; //notre cible
    private Rigidbody2D _rb;
    private float lifeTime = 1.5f;

    private float speed = 8;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("RemoveFireball", lifeTime);
        _rb = GetComponent<Rigidbody2D>();
        _player = GameObject.FindGameObjectWithTag("Player");

        Vector3 direction = _player.transform.position - transform.position;
        _rb.velocity = new Vector2(direction.x, direction.y).normalized * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("touché la boule !");
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<PlayerLifeSystem>().TakeDamage(5);
            Debug.Log(collision.gameObject.GetComponent<PlayerLifeSystem>()._currentPV);
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void RemoveFireball()
    {
        Destroy(gameObject);
    }
}
