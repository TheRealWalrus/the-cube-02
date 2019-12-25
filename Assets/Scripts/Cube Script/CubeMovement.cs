using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{

    private Rigidbody myBody;

    public float speed;

    private void Awake()
    {
        myBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Movement();
    }

    void Movement()
    {
        float h = Input.GetAxisRaw("Horizontal");

        if (h != 0)
        {
            myBody.AddForce(new Vector3(speed * h, 0, 0));
        }
    }
}
