using UnityEngine;
using System.Collections;

public class FireBall : MonoBehaviour
{

    private float speed = 12;
    private float lifeTime = 1;
    private float damage = 2;

    // Use this for initialization
    void Start()
    {
        // Quand l'objet FireBall sera instantié, le compteur pour l'appel de remove démare.
        Invoke("RemoveFireball", lifeTime);
        //InvokeRepeating pour plus tard
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += Vector3.right * Time.deltaTime;
        //transform.Translate(transform.up * speed * Time.deltaTime);
        transform.position += transform.up * speed * Time.deltaTime;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("trigger");
        if (collision.gameObject.CompareTag("Ennemy"))
        {
            Debug.Log("dans la condition");

            //GameObject mage = GameObject.FindWithTag("Player");
            //collision.GetComponent<Stats>().InflictDamage(mage.GetComponent<Stats>().damageAttack);
            //Debug.Log(collision.GetComponent<Stats>().currentPv);
            Debug.Log(collision.name);
            collision.GetComponent<EnemyBase>().TakeDamage(damage);
            Destroy(gameObject);
        }
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    Debug.Log("collision");

    //    if (collision.gameObject.CompareTag("Ennemy"))
    //    {
    //        collision.gameObject.GetComponent<EnemyBase>().TakeDamage(damage);
    //        Destroy(gameObject);
    //    }
    //}




    void RemoveFireball()
    {
        Destroy(gameObject);
    }
}