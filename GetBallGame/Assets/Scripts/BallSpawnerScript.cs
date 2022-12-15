using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawnerScript : MonoBehaviour
{

    //インスペクタで呼び出しballスクリプトと結び付けれるようにする
    public GameObject[] balls;


    void Start()
    {
        //ゲーム開始０秒から1秒ごとにボールを生成する関数を呼び出す
        InvokeRepeating("SpawnBall", 0f, 1f);
    }

/*
    //一定時間でボールを生成する関数
    void SpawnBall()
    {
        Instantiate(balls[3], new Vector3(Random.Range(-5f, 5f), transform.position.y, transform.position.z), transform.rotation);
    }

*/
    
    //ランダムにボールを1つ選ぶ関数
    GameObject GetRandomBall()
    {
        int i = Random.Range(0, balls.Length);
        if (balls[i])
        {
            return balls[i];
        }
        else
        {
            return null;
        }
    }

    //選ばれたブロックを生成する関数
    public GameObject SpawnBall()
    {
        GameObject ball = Instantiate(GetRandomBall(),transform.position, Quaternion.identity);
        if (ball)
        {
            return ball;
        }
        else
        {
            return null;
        }
    }



}
