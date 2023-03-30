using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordZone : MonoBehaviour
{
    [SerializeField]
    private float _lifeTime = 0.3f;

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
}
