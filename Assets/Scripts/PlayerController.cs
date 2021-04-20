using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Range(0, 50), SerializeField]
    int _forwardSpeed  = 20, _turnSpeed = 25;

    [SerializeField]
    float _horizontalInput, _forwardInput;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        _forwardInput = Input.GetAxis("Vertical");

        // Moves the car forward based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * _forwardSpeed * _forwardInput);

        // Moves the car horizontal based on horizontal input
        transform.Rotate(Vector3.up , Time.deltaTime * _turnSpeed * _horizontalInput);
    }
}
