using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLifeSystem : MonoBehaviour
{

    [SerializeField]
    private Image PvBar;

    public float _currentPV;
    private float _initialPv = 50;

    // Start is called before the first frame update
    void Start()
    {
        _currentPV = _initialPv;
    }

    // Update is called once per frame
    void Update()
    {
        PvBar.fillAmount = Mathf.Clamp(_currentPV / _initialPv, 0, 1);
        if (_currentPV <= 0)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }

    public void TakeDamage(float damage)
    {
        _currentPV -= damage;
    }

}
