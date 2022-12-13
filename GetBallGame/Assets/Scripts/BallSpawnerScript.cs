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

    //一定時間でボールを生成する関数
    void SpawnBall()
    {
        Instantiate(ball, new Vector3(Random.Range(-5f, 5f), transform.position.y, transform.position.z), transform.rotation);
    }

    void Update()
    {
        
    }
}
