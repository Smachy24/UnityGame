using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private  Rigidbody2D _rigBod;

    [SerializeField]
    private LayerMask m_GroundLayer;

    private float _movement;
    private bool _isJump;


    [SerializeField]
    private CharacterSwitch m_Switcher;

    private static string _direction;
    public static string direction
    {
        get
        {
            return _direction;
        }
        set
        {
            _direction = value;
        }
    }

    private void Awake()
    {
        _rigBod = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerStats stats = m_Switcher.CurrentStats;

        if (Physics2D.Raycast(transform.position, Vector2.down, stats.playerHeight, m_GroundLayer))
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _isJump = true;
            }
        }
        
        _movement = Input.GetAxis("Horizontal");
        if (_movement > 0)
        {
            _direction = "right";
        }
        else if(_movement < 0)
        {
            _direction = "left";
        }
    }

    private void FixedUpdate()
    {
        PlayerStats stats = m_Switcher.CurrentStats;

        if (_isJump)
        {
            _isJump = false;

            _rigBod.AddForce(Vector2.up * stats.m_JumpForce, ForceMode2D.Impulse);
        }

        _rigBod.velocity = new Vector2(stats.m_MoveSpeed * _movement, _rigBod.velocity.y);
    }

    public void Stop()
    {
        _rigBod.velocity = new Vector2(0, _rigBod.velocity.y);
        enabled = false;
    }
}
