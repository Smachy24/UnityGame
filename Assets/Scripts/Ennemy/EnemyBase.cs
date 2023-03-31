using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    [SerializeField]
    private GameObject _player;
    [SerializeField]
    private float _maxPv;

    //[SerializeField]
    private float _currentPv;

    // Start is called before the first frame update
    void Start()
    {
        _currentPv = _maxPv;
        Debug.Log(_currentPv);
        _player = GameObject.FindGameObjectWithTag("Player");

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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("touché");
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<PlayerLifeSystem>().TakeDamage(5);
            Debug.Log(collision.gameObject.GetComponent<PlayerLifeSystem>()._currentPV);
        }
    }

    public void KillEnemy()
    {
        Destroy(gameObject);
    }
}
