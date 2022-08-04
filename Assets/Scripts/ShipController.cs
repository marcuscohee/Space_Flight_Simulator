using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _currentSpeed;
    private float _vertical;
    private float _horizontal;
    [SerializeField] private float _maxRotation;
    [SerializeField] private UIManager _UIManager;

    void Start()
    {
        _currentSpeed = 40;
        _UIManager.ShipSpeed(_currentSpeed);
    }

    void Update()
    {
        CalculateMovement();
    }
    
    void CalculateMovement()
    {
        _vertical = Input.GetAxis("Vertical");
        _horizontal = Input.GetAxis("Horizontal");

        if (Input.GetKeyDown(KeyCode.T))
        {//Increases speed
            _currentSpeed += 5f;
            if (_currentSpeed > 40)
            {
                _currentSpeed = 40;
            }
            _UIManager.ShipSpeed(_currentSpeed);
        }
        if (Input.GetKeyDown(KeyCode.G))
        {//Decreases speed
            _currentSpeed -= 5;
            if (_currentSpeed < 5)
            {
                _currentSpeed = 5;
            }
            _UIManager.ShipSpeed(_currentSpeed);
        }

        Vector3 rotateH = new Vector3(0, _horizontal, 0);
        Vector3 rotateV = new Vector3(0, 0, _vertical);

        //Horizontal rotation
        transform.Rotate(rotateH * _rotationSpeed * Time.deltaTime, Space.Self);
        //Vertical rotation
        transform.Rotate(rotateV * _rotationSpeed * Time.deltaTime, Space.Self);
        //Move Forward
        transform.position += _currentSpeed * Time.deltaTime * -transform.right;
        //Roll left
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(new Vector3(0.2f, 0, 0), Space.Self);
        }
        //Roll right
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(new Vector3(-0.2f, 0, 0), Space.Self);
        }

    }
}