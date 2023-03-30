using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMeleeAttack : MonoBehaviour
{
    [SerializeField]
    private GameObject _swordZonePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("atk droite");
            Instantiate(_swordZonePrefab, gameObject.transform);
            _swordZonePrefab.transform.position = new Vector2(1,0);


        }
    }
}
