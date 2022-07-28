using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float _sensitivity = 8f;
    public float _maxAngle = 80f;

    private Vector2 currentRotation;
    private Quaternion oldRotation;
    private Quaternion newRotation;

    [DllImport("user32.dll")]
    static extern bool SetCursorPos(int X, int Y);

    void Start()
    {
        int xPos = Screen.width/2, yPos = Screen.height/2;
        SetCursorPos(xPos, yPos);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void FixedUpdate()
    {
        oldRotation = transform.rotation;

        currentRotation.x += Input.GetAxis("Mouse X") * _sensitivity;
        currentRotation.y -= Input.GetAxis("Mouse Y") * _sensitivity;
        currentRotation.x = Mathf.Repeat(currentRotation.x, 360);
        currentRotation.y = Mathf.Clamp(currentRotation.y, -_maxAngle, _maxAngle);
        newRotation = Quaternion.Euler(currentRotation.y, currentRotation.x, 0);

        transform.rotation = Quaternion.Slerp(oldRotation, newRotation, _sensitivity);
    }
}