using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountTextScript : MonoBehaviour
{
    int score = 0;
    public Text scoreText;

    public void ADDScore()
    {
        score++;
    }
}
