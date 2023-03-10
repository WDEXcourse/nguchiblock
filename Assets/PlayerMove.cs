using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody rb;
    public float jumpPower;
    private bool isJumping = false;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        // 前に移動
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(0, 0, 5);
        }

        //　後ろに移動
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(0, 0, -5);
        }

        //　右に移動
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(5, 0, 0);
        }

        // 左に移動
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-5, 0, 0);
        }

        // 落ちたらスタート位置に戻る
        if (transform.position.y < -10)
        {
            transform.position = new Vector3(0, 8, 0);
        }

        // ジャンプ
        if (Input.GetKey(KeyCode.Space) && !isJumping)
        {
            rb.velocity = Vector3.up * jumpPower;
            isJumping = true;
        }
    }

    // 地面にいるかどうかの判定
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            print("着地");
            isJumping = false;
        }
    }
}
