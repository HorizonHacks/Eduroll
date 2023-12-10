using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class comparison1 : MonoBehaviour
{
    public InputField InputField1;
    public InputField InputField2;
    public InputField InputField3;
    private float z_coord = 0f;

    void Start()
    {
        InputField1.text = "1";
        InputField2.text = "1";
        InputField3.text = "1";
        transform.position = new Vector3 (346.3f,5f,128.4f);
    }

    // Update is called once per frame
    void Update()
    {
        float xval1 = float.Parse(InputField1.text);
        float yval1 = float.Parse(InputField2.text);
        float zval1 = float.Parse(InputField3.text);
        Vector3 scale = transform.localScale;
        scale.x = xval1 * 10;
        scale.y = yval1 * 10;
        scale.z = zval1 * 10;
        transform.localScale = scale;
        if (scale.z > 10)
        {
            z_coord = scale.z - 100f;
        }
        transform.position = new Vector3 (346.3f,scale.y/2,128.4f+(z_coord/2));
    }
}
