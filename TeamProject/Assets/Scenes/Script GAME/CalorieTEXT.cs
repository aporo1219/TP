using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CalorieTEXT : MonoBehaviour
{
    public static float CalorieTEXTInitival;//カロリー文字の初期化
    public Text CalorieText;//カロリーの文字の変数
    private float Ctime;//経過時間

    // Start is called before the first frame update
    void Start()
    {
        CalorieTEXTInitival = 100;
    }



    // Update is called once per frame
    void Update()
    {
        Ctime += Time.deltaTime;//カロリー文字の設定
        //時間経過
        if (Ctime >= 1.0f)
        {
            CalorieTEXTInitival -= 2;
            Ctime = 0;
        }
        CalorieText.text = "カロリー:" + CalorieTEXTInitival + "Kcal".ToString();//カロリーのテキスト文字をカロリーの初期値におく
        //上限を100
        if (CalorieTEXTInitival >= 100.0f)
        {
            CalorieTEXTInitival = 100.0f;
        }
        //なくなったらゲームオーバーシーンの切り替え
        if (CalorieTEXTInitival <= 0.0f)
        {
            GAMEOVER();
        }

    }
    public void OnCollisionEnter2D(Collision2D other)
    {



        if (other.gameObject.tag == "chili pepper")
        {
            CalorieTEXTInitival -= 10;

        }
        if (other.gameObject.tag == "chocolate")
        {
            CalorieTEXTInitival += 20;

        }
        if (other.gameObject.tag == "cookie")
        {
            CalorieTEXTInitival += 10;

        }
        if (other.gameObject.tag == "dumbbell")
        {
            CalorieTEXTInitival -= 30;

        }

        if (other.gameObject.tag == "pudding")
        {
            CalorieTEXTInitival += 20;

        }


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "pitfall")
        {
            CalorieTEXTInitival -= 30;

        }
    }

    public void GAMEOVER()
    {
        SceneManager.LoadScene("GameOver1");

    }


}
