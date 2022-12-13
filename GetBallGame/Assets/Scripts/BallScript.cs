using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{

    private float speed;

    // Start is called before the first frame update
    void Start()
    {
        //ランダムに取得
        speed = Random.Range(5f,15f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
