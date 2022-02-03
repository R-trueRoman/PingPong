using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;

public class PlayerController : MonoBehaviour
{
    [SerializeField, Range(0f,100f)]
    private float _moveSpeed = 25f;
    private NewControls _input;
    private Rigidbody2D _rb;
    private Vector3 _startPosition;
    
    private void Stop()
    {
        _rb.velocity = Vector2.zero;
    }

    private void Awake()
    {
        _input = new NewControls();
         _startPosition = transform.position;

        _input.MainActionMap.Stop.performed += _ => Stop();
        _input.MainActionMap.Stop.canceled -= _ => Stop();
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

    private void FixedUpdate()
    {
        var direction = Input.GetAxis("Vertical") *  Time.fixedDeltaTime;
        if (direction == 0f) return;
        _rb.velocity += direction * Vector2.up * _moveSpeed;
    }

    internal void Reset()
    {
        _rb.velocity = Vector2.zero;
        transform.position = _startPosition;
    }
}
