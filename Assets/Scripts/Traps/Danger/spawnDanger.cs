using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnDanger : MonoBehaviour
{
    private void Awake()
    {
        GameObject.FindGameObjectWithTag("Danger").transform.position = transform.position;
    }
}
