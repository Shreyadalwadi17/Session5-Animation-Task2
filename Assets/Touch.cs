//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Touch : MonoBehaviour
//{
//    public Movement mov;
//    public Transform target;
//    public float sensitivity = 4.0f;
//    public float minYAngle = -30.0f;
//    public float maxYAngle = 60.0f;
//    public float distance = 5.0f;
//    private float currentX = 0.0f;
//    private float currentY = 0.0f;

//    void LateUpdate()
//    {

//        target.transform.rotation = Quaternion.AngleAxis(currentX, Vector3.up);

//    }

//    void Update()
//    {

//        Touch touch = Input.GetTouch(0);

//        if (touch.position.x > Screen.width / 2)
//        {
//            if (touch.phase == TouchPhase.Moved)
//            {
//                currentX += touch.deltaPosition.x * sensitivity;
//                currentY -= touch.deltaPosition.y * sensitivity;
//                currentY = Mathf.Clamp(currentY, minYAngle, maxYAngle);
//            }
//        }

//    }
//}
