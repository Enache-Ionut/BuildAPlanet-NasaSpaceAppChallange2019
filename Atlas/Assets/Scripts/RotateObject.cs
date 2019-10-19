using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float rotateSpeed = 1;

    private void OnMouseDrag()
    {
        float rotX = Input.GetAxis("Mouse X") * rotateSpeed * Mathf.Deg2Rad;
        float rotY = Input.GetAxis("Mouse Y") * rotateSpeed * Mathf.Deg2Rad;
        float rotZ = Input.GetAxis("Mouse Z") * rotateSpeed * Mathf.Deg2Rad;


        transform.RotateAround(Vector3.up, -rotX);
        transform.RotateAround(Vector3.right, rotY);
        transform.RotateAround(Vector3.right, -rotZ);

    }

}
