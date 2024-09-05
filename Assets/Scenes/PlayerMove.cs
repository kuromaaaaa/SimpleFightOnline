using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{

    Rigidbody _rb;
    Animator _anim;

    [SerializeField]
    float _moveSpeed;
    [SerializeField]
    float _jumpPower;

    Vector2 _wasd;

    public void OnJump(InputAction.CallbackContext context)
    {
        float value = context.ReadValue<float>();
        if (value > 0) { _rb.AddForce(Vector3.up * _jumpPower, ForceMode.Impulse); }
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        // 
        if(context.ReadValue<Vector2>().sqrMagnitude <= 0.1)
        {
            _wasd = Vector3.zero;
        }
        else
        {
            _wasd = context.ReadValue<Vector2>();
            Debug.Log(_wasd.sqrMagnitude);
            transform.forward = new Vector3(_wasd.x, 0, 0);
        }
    }

    public void On_2HK(InputAction.CallbackContext context)
    {
        float value = context.ReadValue<float>();
        if(value > 0) _anim.SetTrigger("2HK");
    }
    
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        _rb.velocity = new Vector3(_wasd.x * _moveSpeed ,_rb.velocity.y ,0);
        
    }
}
