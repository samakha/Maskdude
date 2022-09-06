using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = GameObject.Find("Player").transform.position;

        transform.position = new Vector3(playerPos.x, playerPos.y, transform.position.z);
    }
}
