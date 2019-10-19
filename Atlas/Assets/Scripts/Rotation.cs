using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float xRotation;
    public float yRotation;
    public float zRotation;

    public 

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TimerFunc());
    }

    // Update is called once per frame
    IEnumerator TimerFunc()
    {
        while (true)
        {
            var delta = Time.deltaTime;

            float rotX = 0;
            float rotY = 0;
            float rotZ = 0;
            if (xRotation != 0)
                rotX = delta * 360 / xRotation;
            if (yRotation != 0)
                rotY = delta * 360 / yRotation;
            if (zRotation != 0)
                rotZ = delta * 360 / zRotation;

            gameObject.transform.Rotate(rotX, rotY, rotZ);

            yield return null;
        }
    }
}
