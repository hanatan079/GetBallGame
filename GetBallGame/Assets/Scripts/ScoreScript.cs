using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreScript : MonoBehaviour
{
    //初期値設定
    public static int score = 0;

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
        score += 100;
        scoreText.text = string.Format("Score{0}", score);
    }

    //
    public static int getScore()
    {
        return score;
    }

    //ボタン押下でメインシーンへ遷移
    public void RePlayGame()
    {
        SceneManager.LoadScene("MainScene");
        //スコアリセット
        score = 0;

    }

}