using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public GameObject player;

    private void Start()
    {
        
    }

    private void Update()
    {
        float posX = player.transform.position.x;  // playerのx座標
        float posY = player.transform.position.y;  // playerのy座標
        float posZ = player.transform.position.z;  // playerのz座標

        transform.position = new Vector3(posX, posY + 10, posZ - 10);
    }
}
