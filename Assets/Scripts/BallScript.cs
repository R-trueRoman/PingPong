using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    private Rigidbody2D _rb;
    [SerializeField, Range(0.1f, 50f)]
    private float _speed;
    [SerializeField]
    private float _directionX;
    [SerializeField]
    private float _directionY;
    private Vector2 _direction;
    [SerializeField]
    private float _randomMin = -5;
    [SerializeField]
    private float _randomMax = 5;
    private Vector3 _lastVelocity;
    [SerializeField]
    private bool _accelerationFromRicoshet;
    [SerializeField, Range(0.1f, 3f)]
    private float _valueOfAcceleration;
    [SerializeField, Range(1, 20), Header("In development (not working)")]
    private float _maxVelocity;
    private Vector3 _startPosition;

    private void Awake()
    {
        _startPosition = transform.position;
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        if(_directionX == 0f && _directionY == 0f)
        {
            _direction = new Vector2(Random.Range(_randomMin, _randomMax), Random.Range(_randomMin, _randomMax));
        }
        else
        {
            _direction = new Vector2(_directionX, _directionY);
        }
        Launch(_direction, _speed);
    }

    private void FixedUpdate()
    {

    }

    private void Launch(Vector2 direction, float speed)
    {
        _rb.AddForce(direction * speed);
    }

    private void Update()
    {
        _lastVelocity = _rb.velocity;
    }

    internal void Reset()
    {
        if (_directionX == 0f && _directionY == 0f)
        {
            _direction = new Vector2(Random.Range(_randomMin, _randomMax), Random.Range(_randomMin, _randomMax));
        }
        else
        {
            _direction = new Vector2(_directionX, _directionY);
        }
        _rb.velocity = Vector2.zero;
        transform.position = _startPosition;
        Launch(_direction, _speed);
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        var speed = _lastVelocity.magnitude;
        var direction = Vector3.Reflect(_lastVelocity.normalized, col.contacts[0].normal);

        if (_accelerationFromRicoshet)
        {
            if (col.gameObject.CompareTag("Player"))
            {
                _rb.velocity = direction * _valueOfAcceleration * Mathf.Max(speed, 0f);
            }
            else
            {
                _rb.velocity = direction * Mathf.Max(speed, 0f);
            }
        }
        else
        {
            _rb.velocity = direction * Mathf.Max(speed, 0f);
        }
    }
}
