using UnityEngine;
using System.Collections;

public class FireBall : MonoBehaviour
{

    private float speed = 8;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += Vector3.right * Time.deltaTime;
        //transform.Translate(transform.up * speed * Time.deltaTime);
        transform.position += transform.up * speed * Time.deltaTime;
    }
}