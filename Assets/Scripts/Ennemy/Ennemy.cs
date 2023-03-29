using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;


public class Ennemy : MonoBehaviour
{

    [SerializeField]
    private float maxPv;

    [SerializeField]
    private float currentPv;

    private Rigidbody2D _rigBod;

    [SerializeField]
    private LayerMask m_GroundLayer;

    [SerializeField]
    private float m_JumpForce;

    [SerializeField]
    private float m_MoveSpeed;

    private float _movement;
    private bool _isJump;



    private string direction = "right";
    
    public void Flip()
    {
        if (direction == "right")
        {
            direction = "left";
        }
        else if (direction == "left")
        {
           direction = "right";
        }

    }


    private void Awake()
    {
        _rigBod = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Physics2D.Raycast(transform.position, Vector2.down, 1f, m_GroundLayer))
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
               
                _isJump = true;
            }
        }*/

        if (direction == "right")
        {
            _movement = 1;
        }
        else
        {
            _movement = -1;
        }

        _rigBod.velocity = new Vector2(m_MoveSpeed * _movement, _rigBod.velocity.y);

        _movement = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        /*if (_isJump)
        {
            _isJump = false;

            _rigBod.AddForce(Vector2.up * m_JumpForce, ForceMode2D.Impulse);
        }*/
       
    }

    public void Stop()
    {

        _rigBod.velocity = new Vector2(0, _rigBod.velocity.y);
        enabled = false;
    }
}
