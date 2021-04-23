using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController_Upgrade : MonoBehaviour
{
    [SerializeField] float _speed; // M/H １時間あたり進む[m]
 
    [SerializeField] float _horsePower  = 20000, _turnSpeed = 25;

    [SerializeField] float _horizontalInput, _verticalInput;
    Rigidbody _playerRb;
    [SerializeField] GameObject _centerOfMass;

    [SerializeField] TextMeshProUGUI _speedometerText;

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

        // get the correct speed by using rigidbody.velocity.magnitude. It returns the speed in M/S.
        // To get the speed in KM/H multiply the magnitude by 3.6f, and to get it in M/H multiply the magnitude by 2.237f.
        _speed = Mathf.RoundToInt(_playerRb.velocity.magnitude * 2.237f); // For kph, change 2.237 to 3.6

        _speedometerText.SetText("Speed: " + _speed.ToString() + "mph");
    }
}
