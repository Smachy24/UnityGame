using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRangeAttack : MonoBehaviour
{
    [SerializeField]
    private FireBall fireballPrefab;

    public float offset;
    private float cooldown = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Recuperation de l'angle de tire
        Vector2 difference = (Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position).normalized;


        transform.up = difference;

        //float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        //rotation du caster en fonction a l'angle récupéré + marge de correction
        //transform.rotation = Quaternion.Euler(0f, 0f, rotZ + offset);
        //Debug.Log(transform.rotation);
        if (Input.GetMouseButtonDown(0) && cooldown <= 0)
        {
            Instantiate(fireballPrefab, transform.position, transform.rotation);
            cooldown = 1;
        }

        if (Input.GetMouseButtonDown(1) && cooldown <= 0)
        {


        }

        cooldown -= Time.deltaTime;

    }
}
