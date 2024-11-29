using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CalorieTEXT : MonoBehaviour
{
    public static float CalorieTEXTInitival;//カロリー文字の変数
    public Text CalorieText;//カロリーの文字の変数
    private float Ctime;//経過時間
    public static int StageInfor;//ステージ情報の取得
   

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;//Aボタン押されるまで停止
        CalorieTEXTInitival = 100;
        StageInfor = 0;//クリアしたステージによってリザルトのスイーツの絵を変える
    }



    // Update is called once per frame
    void Update()
    { 
        if(Input.GetKeyDown(KeyCode.A))
        {
            Time.timeScale = 1;
        }
        CalorieText.text = "カロリー:" + CalorieTEXTInitival + "Kcal".ToString();//カロリーのテキスト文字をカロリーの初期値におく
        Ctime += Time.deltaTime;//カロリー文字の設定
        //時間経過(ステージ１）
        if(SceneManager.GetActiveScene().name == "STAGE1")
        {
          
         
          if (Ctime >= 1.0f)
          {
            CalorieTEXTInitival -= 2;
            Ctime = 0;
           
            StageInfor = 0;
          }
        }
        //時間経過(ステージ2）
        if(SceneManager.GetActiveScene().name == "STAGE2")
        {
            if (Ctime >= 1.0f)
            {
                CalorieTEXTInitival -= 5;
                Ctime = 0;

                StageInfor = 1;
            }
        }
        //時間経過(ステージ3）
        if (SceneManager.GetActiveScene().name == "STAGE3")
        {
            if (Ctime >= 1.0f)
            {
                CalorieTEXTInitival -= 2;
                Ctime = 0;

                StageInfor = 2;
            }
        }
        //時間経過(ステージ4）
        if (SceneManager.GetActiveScene().name == "STAGE4")
        {
            if (Ctime >= 1.0f)
            {
                CalorieTEXTInitival -= 2;
                Ctime = 0;

                StageInfor = 3;
            }
        }
        //時間経過(ステージ5）
        if (SceneManager.GetActiveScene().name == "STAGE5")
        {
            if (Ctime >= 1.0f)
            {
                CalorieTEXTInitival -= 5;
                Ctime = 0;

                StageInfor = 4;
            }
        }


        
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
            CalorieTEXTInitival += 30;

        }

        if(other.gameObject.tag == "Choco night")
        {
            CalorieTEXTInitival += 10;
        }

        if (other.gameObject.tag == "Pud night")
        {
            CalorieTEXTInitival += 15;
        }

        if (other.gameObject.tag == "Cook night")
        {
            CalorieTEXTInitival += 5;
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "pitfall")
        {
            CalorieTEXTInitival -= 20;

        }
    }

   
    public void GAMEOVER()
    {
        SceneManager.LoadScene("GameOver1");

    }


}
