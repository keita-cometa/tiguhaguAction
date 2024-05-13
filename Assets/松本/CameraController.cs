using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Rigidbody rb;
    float forwordpower = 0.01f;//前方向の強制移動の力
    float times = 1.00001f;//徐々に加速するための

    public PlayerController playerController;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //rb.velocity = Vector3.forward * 2.0f;//前方向に２Nの力で移動する
        transform.position += forwordpower * transform.forward;

        forwordpower *= times;

        if(playerController.isClear|| playerController.isOver)
        {
            forwordpower = 0.0f;
        }
    }
}
