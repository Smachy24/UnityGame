using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class throwArraw : MonoBehaviour
{
    [SerializeField] GameObject arrowType;
    [SerializeField] float arrowSpeed;
    [SerializeField] float arrowRate;
    [SerializeField] Quaternion arrowOrientation;

    private float nextArrowTime = 0.0f;
    // Update is called once per frame
    void Update()
    {
   
            if (Time.time > nextArrowTime)
            {
                nextArrowTime = Time.time + arrowRate;

                GameObject arrow = Instantiate(arrowType, transform.position, arrowOrientation);
                arrow.GetComponent<Rigidbody2D>().AddForce(transform.right * arrowSpeed, ForceMode2D.Impulse);
            }
        
    }




}
