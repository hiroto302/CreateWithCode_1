using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController_Upgrade : MonoBehaviour
{
    [SerializeField]
    float _horsePower  = 20000, _turnSpeed = 25;

    [SerializeField]
    float _horizontalInput, _verticalInput;
    Rigidbody _playerRb;
    [SerializeField] GameObject _centerOfMass;

    void Start()
    {
        _playerRb = GetComponent<Rigidbody>();
        _playerRb.centerOfMass = _centerOfMass.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        _verticalInput = Input.GetAxis("Vertical");

        // Moves the car forward based on vertical input
        // AddRelativeForce : ローカル座標に対して Rigidbody に相対的な力を加える
        _playerRb.AddRelativeForce(Vector3.forward * _horsePower * _verticalInput);

        // Moves the car horizontal based on horizontal input
        transform.Rotate(Vector3.up , Time.deltaTime * _turnSpeed * _horizontalInput);
    }
}
