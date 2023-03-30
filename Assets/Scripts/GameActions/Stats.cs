using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    [SerializeField]
    private int _maxPv;

    [SerializeField]
    public int _currentPv;

    [SerializeField]
    private int _damageAttack;

    public int maxPv
    {
        get
        {
            return _maxPv;
        }
        set
        {
            _maxPv = value;
        }
    }
    public int currentPv
    {
        get
        {
            return _currentPv;
        }
        set
        {
            _currentPv = value;
        }
    }
    public int damageAttack
    {
        get
        {
            return _damageAttack;
        }
        set
        {
            _damageAttack = value;
        }
    }

    public void InflictDamage(int attack)
    {
        _currentPv-=attack;
    }

}
