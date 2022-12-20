using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AutomaticMovement : MonoBehaviour
{
    //経過時間用
     private float step_time;

    // Start is called before the first frame update
    void Start()
    {
        //経過時間初期化
        step_time = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        // 経過時間をカウント
        step_time += Time.deltaTime;

        // 1.5秒後に画面遷移
        if (step_time >= 1.5f)
        {
            SceneManager.LoadScene("LizardoSene");
        }

    }
}
