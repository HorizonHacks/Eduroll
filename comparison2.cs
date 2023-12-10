using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class comparison2 : MonoBehaviour
{
    public InputField InputField4;
    public InputField InputField5;
    public InputField InputField6;
    private float x_coord = 0f;
    private float z_coord = 0f;

    void Start()
    {
        InputField4.text = "1";
        InputField5.text = "1";
        InputField6.text = "1";
        transform.position = new Vector3 (447f + x_coord,5f,128.4f);
    }

    void Update()
    {
        float xval2 = float.Parse(InputField4.text);
        float yval2 = float.Parse(InputField5.text);
        float zval2 = float.Parse(InputField6.text);
        Vector3 scale = transform.localScale;
        scale.x = xval2 * 10;
        scale.y = yval2 * 10;
        scale.z = zval2 * 10;
        transform.localScale = scale;
        if (scale.x > 10)
        {
            x_coord = scale.x - 100f;
        }
        if (scale.z > 10)
        {
            z_coord = scale.z - 100f;
        }
        transform.position = new Vector3 (447f + (x_coord/2),scale.y/2,128.4f+(z_coord/2));
    }
}
