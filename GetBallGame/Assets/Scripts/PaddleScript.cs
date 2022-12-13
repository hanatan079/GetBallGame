using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour
{
    public float speed;

    void Start()
    {

    }

    void Update()
    {
        //矢印キーの押下でパドルを左右に動かせるようにする (deltatime前回のフレームからの経過時間)
        transform.position += new Vector3(Input.GetAxis("Horizontal") * Time.deltaTime * speed, 0f, 0f);
    }
}
