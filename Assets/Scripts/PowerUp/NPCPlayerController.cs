using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCPlayerController : MonoBehaviour
{
    private Rigidbody2D _rigBod;

    [SerializeField]
    private LayerMask m_GroundLayer;

    private float _movement;
    private bool _isJump;
    private float jumpForce = 15;
    private float moveSpeed = 15;
    private float playerHeight = 1;

    

    private void Awake()
    {
        _rigBod = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
 

        if (Physics2D.Raycast(transform.position, Vector2.down, playerHeight, m_GroundLayer))
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _isJump = true;
            }
        }
        
        _movement = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
      

        if (_isJump)
        {
            _isJump = false;

            _rigBod.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }

        _rigBod.velocity = new Vector2(moveSpeed * _movement, _rigBod.velocity.y);
    }

    public void Stop()
    {
        _rigBod.velocity = new Vector2(0, _rigBod.velocity.y);
        enabled = false;
    }

}
