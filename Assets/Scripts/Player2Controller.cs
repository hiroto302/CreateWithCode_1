using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player2Controller : MonoBehaviour
{
    [SerializeField] float _horsePower  = 20000, _turnSpeed = 25;

    [SerializeField] float _horizontalInput, _verticalInput;
    Rigidbody _playerRb;
    [SerializeField] GameObject _centerOfMass;
    [SerializeField] List<WheelCollider> _allWheels;
    [SerializeField] int _wheelsOnGround;

    void Start()
    {
        _playerRb = GetComponent<Rigidbody>();
        // _playerRb.centerOfMass = _centerOfMass.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // 矢印入力操作
        if(Input.GetKey(KeyCode.RightArrow))
        {
            _horizontalInput = 1.0f;
        }
        else if(Input.GetKey(KeyCode.LeftArrow))
        {
            _horizontalInput = -1.0f;
        }
        else
        {
            _horizontalInput = 0;
        }

        if(Input.GetKey(KeyCode.UpArrow))
        {
            _verticalInput = 1.0f;
        }
        else if(Input.GetKey(KeyCode.DownArrow))
        {
            _verticalInput = -1.0f;
        }
        else
        {
            _verticalInput = 0;
        }

        if(IsOnGround())
        {
            // Moves the car forward based on vertical input
            // AddRelativeForce : ローカル座標に対して Rigidbody に相対的な力を加える
            _playerRb.AddRelativeForce(Vector3.forward * _horsePower * _verticalInput);

            // Moves the car horizontal based on horizontal input
            transform.Rotate(Vector3.up , Time.deltaTime * _turnSpeed * _horizontalInput);
        }
    }

    bool IsOnGround()
    {
        _wheelsOnGround = 0;
        foreach(var wheel in _allWheels)
        {
            if(wheel.isGrounded)
            {
                _wheelsOnGround++;
            }
        }
        if(_wheelsOnGround == 4)
        {
            return  true;
        }
        else
        {
            return false;
        }
    }
}
