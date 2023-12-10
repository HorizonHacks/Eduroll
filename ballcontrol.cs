using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    public Rigidbody rigid;
    public float ball_speed = 10f;
    private float x_input;
    private float z_input;
    private float resetx = -78.88602f;
    private float resetz = 0f;
    void Start()
    {
        Physics.gravity = new Vector3(0, -20f, 0);
        transform.position = new Vector3(resetx, 8f, resetz);
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Cube")
        {
            Vector3 velocity = rigid.velocity;
            velocity.y = 13f;
            rigid.velocity = velocity;
        }
         if (collision.gameObject.name == "Cube Fin")
        {
            Vector3 velocity = rigid.velocity;
            velocity.y = 55f;
            rigid.velocity = velocity;
        }
        if (collision.gameObject.name == "ReliablePress")
        {
            Vector3 currentPosition = transform.position;
            currentPosition.z += 20f;
            currentPosition.x = -78.88602f;
            transform.position = currentPosition;
            Vector3 force = new Vector3(0f , 0f, 50f);
            rigid.AddForce(force);
        }
        if (collision.gameObject.name == "checkpoint1")
        {
            resetx = -78.88602f;
            resetz = 185f;
        }
        if (collision.gameObject.name == "BigJump")
        {
            Vector3 velocity = rigid.velocity;
            velocity.y = 160f;
            rigid.velocity = velocity;
            resetx = 140.5f;
        }
        if (collision.gameObject.name == "center")
        {
            Vector3 velocity = rigid.velocity;
            velocity.y = 25f;
            rigid.velocity = velocity;
        }
        if (collision.gameObject.name == "ramp")
        {
            resetx = -78.88602f;
            resetz = 0f;
        }
        if (collision.gameObject.name == "return")
        {
            resetx = -78.88602f;
            resetz = 0f;
            transform.position = new Vector3(resetx, 8f, resetz);
        }
    }
    void Update()
    {
        Inputs();
        if (transform.position.y < -5)
        {
            transform.position = new Vector3(resetx, 8f, resetz);
        }
    }

    private void FixedUpdate()
    {
        Movement();
    }

    private void Inputs()
    {
        x_input = 0f;
        z_input = 0f;
        x_input = Input.GetAxis("Horizontal");
        z_input = Input.GetAxis("Vertical");
    }

    private void Movement()
    {
        if (rigid.velocity.magnitude > 24)
        {
            z_input = 0f;
        }
        Vector3 force = new Vector3(x_input, 0f, z_input) * ball_speed;
        rigid.AddForce(force);
    }
}
