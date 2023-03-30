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
    private int _damageAttackGuerrier;

    [SerializeField]
    private int _damageAttackMage;

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

    public int damageAttackGuerrier
    {
        get
        {
            return _damageAttackGuerrier;
        }
        set
        {
            _damageAttackGuerrier = value;
        }
    }

    public int damageAttackMage
    {
        get
        {
            return _damageAttackMage;
        }
        set
        {
            _damageAttackMage = value;
        }
    }

    public void InflictDamage(int attack)
    {
        _currentPv-=attack;
    }

}
