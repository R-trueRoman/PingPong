using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;

public class SecondController : MonoBehaviour
{
    [SerializeField, Range(0f, 100f)]
    private float _moveSpeed = 10f;
    private NewControls _input;
    private Rigidbody2D _rb;
    private Vector3 _startPosition;

    private void Awake()
    {
        _startPosition = transform.position;
        _input = new NewControls();
    }
    private void OnEnable()
    {
        _input.Enable();
    }

    private void OnDisable()
    {
        _input.Disable();
    }

    private void OnDestroy()
    {
        _input.Dispose();
    }

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            _rb.velocity = Vector2.zero;
        }
        else { Move(); }
    }

    private void FixedUpdate()
    {
    }

    private void Move()
    {
        var moveInput = _input.MainActionMap.UpDown.ReadValue<float>();

        _rb.velocity += moveInput * Vector2.up * _moveSpeed * Time.deltaTime;
    }

    internal void Reset()
    {
        _rb.velocity = Vector2.zero;
        transform.position = _startPosition;
    }
}
