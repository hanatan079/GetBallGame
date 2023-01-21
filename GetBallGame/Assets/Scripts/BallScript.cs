using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallScript : MonoBehaviour
{

    private float speed;

    //初期設定
    GameObject scoreObject;

    // Start is called before the first frame update
    void Start()
    {
        //5~15の間でランダムなスピード
        speed = Random.Range(5f,15f);

        scoreObject = GameObject.Find("Score");
    }

    // Update is called once per frame
    void Update()
    {
        //位置を指定(-1→手前に転がす為)
        transform.position += new Vector3(0f, 0f, -1 * speed * Time.deltaTime);

        //パドルを超えたら一時停止
        if (transform.position.z < -13.0f)
        {
            //Time.timeScale = 0;
            SceneManager.LoadScene("GameOverScene");
        }

    }

        //衝突判定
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Paddle"))
            {
                
                scoreObject.GetComponent<ScoreScript>().AddScore();
                Destroy(gameObject);

                //オブジェクトを0.2~1.0の間でランダムに縮小する
                collision.gameObject.transform.localScale -= new Vector3(Random.Range(0.2f, 1.0f), 0f, 0f);

                //xが１の方が大きくなったら、1.0の正方形にする(それ以上小さくならない)
                if (collision.gameObject.transform.localScale.x < 1.0f)
                {
                    collision.gameObject.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
                }
            }
        }

}
