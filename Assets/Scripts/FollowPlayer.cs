using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    Vector3 _offset;

    public Transform target;

    void Start()
    {
        _offset = transform.position;
    }

    void Update()
    {
        // Offset the camera behind the player(car) by adding to player's position
        transform.position = target.position + _offset;
    }
}
