using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour
{
    public float speed;

    //パドルの移動範囲
    public float xRange =5;


    void Start()
    {

    }

    void Update()
    {
        //矢印キーの押下でパドルを左右に動かせるようにする (deltatime前回のフレームからの経過時間)
        transform.position += new Vector3(Input.GetAxis("Horizontal") * Time.deltaTime * speed, 0f, 0f);

        //パドルの移動範囲設定
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange,  transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

    }
}
