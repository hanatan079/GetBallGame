using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreDisplay : MonoBehaviour
{

    //呼び出可能変数作成
     public Text ScoreText;

    //スコア変数作成
    int score;

    // Start is called before the first frame update
    void Start()
    {
         score = ScoreScript.getScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
