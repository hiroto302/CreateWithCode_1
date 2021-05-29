using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    [SerializeField] GameObject _subCamera;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            SwitchCamera();
        }
    }

    // カメラの切り替え
    void SwitchCamera()
    {
        bool isActive = _subCamera.activeSelf;
        _subCamera.SetActive(!isActive);
    }
}
