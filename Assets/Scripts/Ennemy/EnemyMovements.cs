using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovements : MonoBehaviour
{
    public float speed;
    public Transform[] waypoints;

    private Transform target;
    private int desIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        target = waypoints[1];
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(speed * Time.deltaTime * dir.normalized, Space.World);
        if (Vector3.Distance(target.position, transform.position) < 0.3f)
        {
            desIndex = (desIndex + 1) % waypoints.Length;
            target = waypoints[desIndex];
        }
    }
}
