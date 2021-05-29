using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1CameraController : MonoBehaviour
{
    Vector3 _offset;

    public Transform target;

    void Start()
    {
        // _offset = transform.position;
        _offset = new Vector3(0, transform.position.y, transform.position.z);
    }

    void Update()
    {
        // Offset the camera behind the player(car) by adding to player's position
        transform.position = target.position + _offset;
    }
}
