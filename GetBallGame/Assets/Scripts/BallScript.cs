using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{

    private float speed;

    // Start is called before the first frame update
    void Start()
    {
        //5~15の間でランダムなスピード
        speed = Random.Range(5f,15f);
    }

    // Update is called once per frame
    void Update()
    {
        //位置を指定(-1→手前に転がす為)
        transform.position += new Vector3(0f, 0f, -1 * speed * Time.deltaTime);

        //衝突判定
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.GameObject.CompareTag("Paddle"))
            {
                Destroy(GameObject);
            }
        }
    }
}
