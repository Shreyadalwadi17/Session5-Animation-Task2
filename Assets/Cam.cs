using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    public Transform target;
    public float sensitivity = 2.0f;
    public float minYAngle = -30.0f;
    public float maxYAngle = 60.0f;
    public float distance = 5.0f;
    private float currentX = 0.0f;
    public float heightOffset = 1.0f;
    public Movement mov;


    private float currentY = 0.0f;

    void Update()
    {
        currentX += Input.GetAxis("Mouse X") * sensitivity;
        currentY -= Input.GetAxis("Mouse Y") * sensitivity;
        currentY = Mathf.Clamp(currentY, minYAngle, maxYAngle);
    }


    void LateUpdate()
    {
        Vector3 dir = new Vector3(0, 0, -distance);
        Quaternion rotation = Quaternion.Euler(currentY, currentX, 0);
        transform.position = target.position + rotation * dir + Vector3.up * heightOffset;
        transform.rotation = rotation;

        if (Mathf.Abs(Input.GetAxis("Horizontal")) > 0.1f || Mathf.Abs(Input.GetAxis("Vertical")) > 0.1f)
        {
            target.transform.rotation = Quaternion.AngleAxis(currentX, Vector3.up);
        }


    }


}

