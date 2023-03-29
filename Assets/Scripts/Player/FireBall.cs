using UnityEngine;
using System.Collections;

public class FireBall : MonoBehaviour
{

    private float speed = 12;
    private float lifeTime = 1;

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

        if (collision.gameObject.CompareTag("Ennemy"))
        {
            // collision.GetComponent<Ennemy>().Flip();
            Debug.Log("222");

        }
    }

    void RemoveFireball()
    {
        Destroy(gameObject);
    }
}