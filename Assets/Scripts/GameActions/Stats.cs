using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    [SerializeField]
    private int maxPv;

    [SerializeField]
    private int currentPv;

    [SerializeField]
    private int damageAttack;

    
    public void InflictDamage(int attack)
    {
        currentPv-=attack;
    }

}
