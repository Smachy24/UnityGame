using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRangeAttack : MonoBehaviour
{

    [SerializeField]
    private GameObject _enemyFireBall;

    [SerializeField]
    private float _enemyCooldownInitialValue;

    private float cooldown;
    // Start is called before the first frame update
    void Start()
    {
        cooldown = _enemyCooldownInitialValue;
    }

    // Update is called once per frame
    void Update()
    {
        cooldown -= Time.deltaTime;
        if (cooldown <= 0)
        {
            Instantiate(_enemyFireBall, transform.position, Quaternion.identity);
            cooldown = _enemyCooldownInitialValue;
        }
    }
}
