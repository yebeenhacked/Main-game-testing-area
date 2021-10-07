using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    float turnSpeed = 270f;
    float headUpperAngleLimit = 85f;
    float headLowerAngleLimit = -80f;

    float yaw = 0f;
    float pitch = 0f;

    Quaternion bodyStartOrientation;
    Quaternion headStartOrientatiob;

    Transform head;

    private void Start()
    {
        head = GetComponentInChildren<Camera>().transform;
        bodyStartOrientation = transform.localRotation;
        headStartOrientatiob = head.transform.localRotation;

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        var horizontal = Input.GetAxis("Mouse X") * Time.deltaTime * turnSpeed;
        var vertical = Input.GetAxis("Mouse Y") * Time.deltaTime * turnSpeed;

        yaw += horizontal;
        pitch += vertical;

        pitch = Mathf.Clamp(pitch, headLowerAngleLimit, headUpperAngleLimit);

        var bodyRotation = Quaternion.AngleAxis(yaw, Vector3.up);
        var headRotation = Quaternion.AngleAxis(pitch, Vector3.left);

        transform.localRotation = bodyRotation * bodyStartOrientation;
        head.localRotation = headRotation * headStartOrientatiob;
    }





}
