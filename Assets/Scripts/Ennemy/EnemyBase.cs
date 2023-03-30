using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    //[SerializeField]
    private float _maxPv;

    //[SerializeField]
    private float _currentPv = 20;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(_currentPv);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage (float damage)
    {
        _currentPv -= damage;
        Debug.Log(_currentPv);
        if (_currentPv <= 0)
        {
            KillEnemy();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("touché");
    }

    public void KillEnemy()
    {
        Destroy(gameObject);
    }
}
