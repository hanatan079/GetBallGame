using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawnerScript : MonoBehaviour
{

    //インスペクタで呼び出しballスクリプトと結び付けれるようにする
    public GameObject ball;

    void Start()
    {
        //ゲーム開始０秒から1秒ごとにボールを生成する関数を呼び出す
        InvokeRepeating("SpawnBall", 0f, 1f);
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
