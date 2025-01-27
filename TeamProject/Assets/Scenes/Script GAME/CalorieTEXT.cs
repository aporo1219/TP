using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CalorieTEXT : MonoBehaviour
{
    public static float CalorieTEXTInitival;//カロリー文字の値の変数
    public Text CalorieText;//カロリーの文字の変数
    private float Calorietime;//経過時間
    public static int StageInfor;//ステージ情報の取得
    public Text RemainingDistance;//残り距離のテキスト
    public float Distance;//残り距離の変数
    public float Way;//残り距離計算用の変数
    private float StayTime;
    public GameObject NotEnergy;
    public GameObject NotEnergyBack;



    // Start is called before the first frame update
    void Start()
    {
        Distance = 37.0f;
        Time.timeScale = 0;//Aボタン押されるまで停止
        CalorieTEXTInitival = 100;//カロリーテキストの初期化
        StageInfor = 0;//クリアしたステージによってリザルトのスイーツの絵を変える
        NotEnergy.SetActive(false);
        NotEnergyBack.SetActive(false);
    }



    // Update is called once per frame
    void Update()
    {
        //Aボタンを押したらゲームスタート
        if (Input.GetKeyDown(KeyCode.A))
        {
            IsPause();
        }

        //カロリーテキスト関連の関数
        CalorieCharacter();

        //距離関連の関数
        RemainingDistanceFunction();
        

    }
    public void IsPause()
    {
        Time.timeScale = 1;
    }
    
    //カロリーテキスト関連の関数
    //説明
    public void CalorieCharacter()
    {
        //カロリーのテキスト文字の表示
        CalorieText.text = "カロリー:" + CalorieTEXTInitival + "Kcal".ToString();
        Calorietime += Time.deltaTime;//カロリー文字の設定
        
        

        //時間経過(ステージ１）
        if (SceneManager.GetActiveScene().name == "STAGE1")
        {
            if (Calorietime >= 1.0f)
            {
                CalorieTEXTInitival -= 2;
                Calorietime = 0;

                StageInfor = 0;
            }
        }
        //時間経過(ステージ2）
        if (SceneManager.GetActiveScene().name == "STAGE2")
        {
            if (Calorietime >= 1.0f)
            {
                CalorieTEXTInitival -= 5;
                Calorietime = 0;

                StageInfor = 1;
            }
        }
        //時間経過(ステージ3）
        if (SceneManager.GetActiveScene().name == "STAGE3")
        {
            if (Calorietime >= 1.0f)
            {
                CalorieTEXTInitival -= 2;
                Calorietime = 0;

                StageInfor = 2;
            }
        }
        //時間経過(ステージ4）
        if (SceneManager.GetActiveScene().name == "STAGE4")
        {
            if (Calorietime >= 1.0f)
            {
                CalorieTEXTInitival -= 2;
                Calorietime = 0;

                StageInfor = 3;
            }
        }

        //時間経過(ステージ5）
        if (SceneManager.GetActiveScene().name == "STAGE5")
        {
            if (Calorietime >= 1.0f)
            {
                CalorieTEXTInitival -= 5;
                Calorietime = 0;

                StageInfor = 4;
            }
        }
        
        //上限を100にし、100を超えると数値を100にする
        if (CalorieTEXTInitival >= 100.0f)
        {
            CalorieTEXTInitival = 100.0f;
        }

        //カロリーゲージが０になるとゲームオーバーシーンに代わる
        if (CalorieTEXTInitival <= 0.0f)
        {
            GameOver();
        }
      
      
    }

    //距離の関数
    public void RemainingDistanceFunction()
    {
        Way += Time.deltaTime;//残り距離を計算すための処理
        RemainingDistance.text = "お店までの距離は" + Distance + "メートルです。".ToString();//残り距離のテキスト
        //残り距離の計算
        if(Way >= 1.0f)
        {
            Distance -= 1;
            Way = 0;
        }
    }

    //オブジェクトに当たった時の処理
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "pitfall")
        {
            CalorieTEXTInitival -= 20;

        }

        if (collision.gameObject.tag == "chili pepper")
        {
            CalorieTEXTInitival -= 10;

        }
        if (collision.gameObject.tag == "chocolate")
        {
            CalorieTEXTInitival += 20;

        }
        if (collision.gameObject.tag == "cookie")
        {
            CalorieTEXTInitival += 10;

        }
        if (collision.gameObject.tag == "dumbbell")
        {
            CalorieTEXTInitival -= 30;

        }

        if (collision.gameObject.tag == "pudding")
        {
            CalorieTEXTInitival += 30;

        }

        if (collision.gameObject.tag == "Choco night")
        {
            CalorieTEXTInitival += 10;
        }

        if (collision.gameObject.tag == "Pud night")
        {
            CalorieTEXTInitival += 15;
        }

        if (collision.gameObject.tag == "Cook night")
        {
            CalorieTEXTInitival += 5;
        }
    }

    

   public void GameOver()
   { 
        NotEnergy.SetActive(true);
        NotEnergyBack.SetActive(true);
        StayTime += Time.deltaTime;
        if(StayTime >= 3)
        {
          SceneManager.LoadScene("GAMEOVER1");
           StayTime = 0;
        }
    }
}
