using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerTrap : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject arrowType;
    [SerializeField] float arrowSpeed;
    [SerializeField] Quaternion arrowOrientation;

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject arrow = Instantiate(arrowType, transform.position, arrowOrientation);
        arrow.GetComponent<Rigidbody2D>().AddForce(transform.right * arrowSpeed, ForceMode2D.Impulse);
    }
}
