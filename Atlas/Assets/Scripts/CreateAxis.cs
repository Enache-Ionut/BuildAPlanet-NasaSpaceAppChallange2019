using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateAxis : MonoBehaviour
{
    public bool isAxisVisible;
    public float width;
    public float length;
    private GameObject cylinder;

    // Start is called before the first frame update
    void Start()
    {
        cylinder = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        cylinder.transform.position = gameObject.transform.position;
        cylinder.transform.localScale = new Vector3(width, length, width);
    }

    // Update is called once per frame
    void Update()
    {
        if (isAxisVisible)
        {
            cylinder.SetActive(true);
        }
        else
        {
            cylinder.SetActive(false);
        }
        cylinder.transform.rotation = gameObject.transform.rotation;
        cylinder.transform.localScale = new Vector3(width, length, width);
    }
}
