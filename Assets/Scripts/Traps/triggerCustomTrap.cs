using Mono.Cecil;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerCustomTrap : MonoBehaviour
{
    [SerializeField] GameObject arrowType;
    [SerializeField] float arrowSpeed;
    [SerializeField] Quaternion arrowOrientation;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameObject arrow = Instantiate(arrowType, transform.position, arrowOrientation);
            arrow.GetComponent<Rigidbody2D>().AddForce(transform.right * arrowSpeed, ForceMode2D.Impulse);
        }
    }
}
