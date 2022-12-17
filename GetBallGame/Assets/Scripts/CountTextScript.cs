using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Text Mesh Proのエンジン
using TMPro;


public class CountTextScript : MonoBehaviour
{
    int score = 0;
    public TextMeshProUGUI scoreText;

    public void ADDScore()
    {
        score++;
    }

    void update()
    {
        scoreText.text = "SCORE:" + score.ToString();
    }
}
