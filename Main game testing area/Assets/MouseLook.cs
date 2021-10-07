using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class MouseLook : MonoBehaviour
{
    public Vector3 jump;
    public float jumpForce = 600f;

    public bool isGrounded;
    Rigidbody rd;


    float turnSpeed = 600f;
    float headUpperAngleLimit = 85f;
    float headLowerAngleLimit = -80f;

    float yaw = 0f;
    float pitch = 0f;

    Quaternion bodyStartOrientation;
    Quaternion headStartOrientatiob;

    Transform head;
    Transform area;

    private void Start()
    {
        rd = GetComponent<Rigidbody>();
        jump = new Vector3(0, 2.0f, 0);

        head = GetComponentInChildren<Camera>().transform;
        area = GameObject.Find("Point").transform;

        bodyStartOrientation = transform.localRotation;
        headStartOrientatiob = head.transform.localRotation;

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void OnCollisionStay()
    {
        isGrounded = true;
    }

    private void Update()
    {
        



        Debug.Log(transform.rotation);
        var horizontal = Input.GetAxis("Mouse X") * Time.deltaTime * turnSpeed;
        var vertical = Input.GetAxis("Mouse Y") * Time.deltaTime * turnSpeed;

        yaw += horizontal;
        pitch += vertical;

        pitch = Mathf.Clamp(pitch, headLowerAngleLimit, headUpperAngleLimit);

        var bodyRotation = Quaternion.AngleAxis(yaw, Vector3.up);
        var headRotation = Quaternion.AngleAxis(pitch, Vector3.left);

        transform.localRotation = bodyRotation * bodyStartOrientation;
        area.localRotation = headRotation * headStartOrientatiob;


        if (Input.GetMouseButton(1) && head.transform.localPosition.z >= -10)
        {
            head.transform.localPosition = head.transform.localPosition + new Vector3(0, 0, -5 * Time.deltaTime);

        }
        if (Input.GetMouseButton(0) && head.transform.localPosition.z <= 0)
        {
            head.transform.localPosition = head.transform.localPosition + new Vector3(0, 0, 5 * Time.deltaTime);

        }


        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * 6, transform);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime * 4, transform);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * 4, transform);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * 4, transform);
        }
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rd.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0f) // backwards
        {
            head.transform.localPosition = head.transform.localPosition + new Vector3(0, 0, -50 * Time.deltaTime);
        }
        if (Input.GetAxis("Mouse ScrollWheel") > 0f) // forwards
        {
            head.transform.localPosition = head.transform.localPosition + new Vector3(0, 0, 50 * Time.deltaTime);
        }




    }





}
