using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(0, 0, 5);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(0, 0, -5);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(5, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-5, 0, 0);
        }

        if (transform.position.y < -10)
        {
            transform.position = new Vector3(0, 8, 0);
        }
    }
}
