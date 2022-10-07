using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
//We want to intelligently distinguish whether we are currently at unity editor or not

public class CameraMouseInput : MonoBehaviour
{
    [SerializeField]
    private OrbitCamera _cam;

    private Vector3 _prevMousePos;

    void Update()
    {
        const int LeftButton = 0;
        if (!Input.GetMouseButton(LeftButton) || Input.GetMouseButton(LeftButton))
        {
            // mouse movement in pixels this frame
            Vector3 mouseDelta = Input.mousePosition - _prevMousePos;

            // adjust to screen size
            Vector3 moveDelta = mouseDelta * (360f / Screen.height);

            _cam.Move(moveDelta.x, -moveDelta.y);
        }
        _prevMousePos = Input.mousePosition;
    }
}