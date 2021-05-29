using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 対向車を制御するクラス
// 直線に一定の速度で走らせる
public class OncomingVehicleController : MonoBehaviour
{
    [SerializeField] float _forwardSpeed = 20.0f;

    Rigidbody _myRb;
    [SerializeField] GameObject _centerOfMass;

    void Start()
    {
        _myRb = GetComponent<Rigidbody>();
        // _myRb.centerOfMass = _centerOfMass.transform.position;
    }

    void Update()
    {
        // この車のローカルのz軸方向を取得して、それにスピードをかける
        _myRb.velocity = transform.forward * _forwardSpeed;
    }

}
