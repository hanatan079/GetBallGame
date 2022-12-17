using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    //初期値設定
    int score = 0;

    //テキストを呼び出せるようにする
    public Text scoreText;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //スコア表示
        scoreText.text = "SCORE: " + score.ToString();
    }

    public void AddScore()
    {
        score++;
    }

}
