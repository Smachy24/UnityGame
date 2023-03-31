using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordZone : MonoBehaviour
{
    [SerializeField]
    private float _lifeTime = 0.3f;
    private float damage = 8;

    [SerializeField]
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("RemoveSwordZone", _lifeTime);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void RemoveSwordZone()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Ennemy"))
        {
            Debug.Log(collision.name);
            collision.GetComponent<EnemyBase>().TakeDamage(damage);

            Debug.Log(player.name);
        }
    }
}
