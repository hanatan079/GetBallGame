using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawnerScript : MonoBehaviour
{

    //インスペクタで呼び出しballスクリプトと結び付けれるようにする
    public GameObject ball;

    void Start()
    {
        //インスタンスの生成
        Instantiate(ball, transform.position, transform.rotation);
    }

    void Update()
    {
        
    }
}
