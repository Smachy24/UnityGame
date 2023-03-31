using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingplatform : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] Transform platform;
    [SerializeField] Transform startPoint;
    [SerializeField] Transform endPoint;
    [SerializeField] float speed = 1.5f;
    Vector2 targetPos;

    private void Start()
    {
        targetPos = startPoint.position;
    }
    private void Update()
    {
        if (Vector2.Distance(platform.position, startPoint.position) < .1f)
        {
            targetPos = endPoint.position;
        }
        
        if (Vector2.Distance(platform.position, endPoint.position) < .1f)
        {
            targetPos = startPoint.position;
        }

        platform.position = Vector2.MoveTowards(platform.position, targetPos, speed * Time.deltaTime);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.transform.SetParent(this.transform);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.transform.SetParent(null);
        }
    }
}
