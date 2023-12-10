using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject target;
    public float x_offset, y_offset, z_offset;

    void Update()
    {
        Quaternion currentRotation = transform.rotation;
        transform.position = target.transform.position + new Vector3(x_offset, y_offset, z_offset);
        transform.LookAt(target.transform.position);
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Rotate(-9.462f,0,0);
        }
    }
}
