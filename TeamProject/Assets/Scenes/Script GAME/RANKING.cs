using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class RANKING : MonoBehaviour
{
    public Text highcalorieTEXT;//ハイカロリー数を表示するTEXT
    public Text highcalorieTEXT2;//ハイカロリー数を表示するTEXT
    public Text highcalorieTEXT3;//ハイカロリー数を表示するTEXT
    public Text highcalorieTEXT4;//ハイカロリー数を表示するTEXT
    public Text highcalorieTEXT5;//ハイカロリー数を表示するTEXT
    public GameObject Messagetext;//ハイスコアメッセージの表示、非表示
    public GameObject HCT1;//ハイカロリー数を表示するTEXTを表示、非表示
    public GameObject HCT2;//ハイカロリー数を表示するTEXTを表示、非表示
    public GameObject HCT3;//ハイカロリー数を表示するTEXTを表示、非表示
    public GameObject HCT4;//ハイカロリー数を表示するTEXTを表示、非表示
    public GameObject HCT5;//ハイカロリー数を表示するTEXTを表示、非表示
    public static int HC1;//ハイカロリー数の変数
    public static int HC2;//ハイカロリー数の変数
    public static int HC3;//ハイカロリー数の変数
    public static int HC4;//ハイカロリー数の変数
    public static int HC5;//ハイカロリー数の変数

    

    public void Start()
    {
        Messagetext.SetActive(false);//メッセージテキストを非表示
        //今までの最高記録を変数に挿入する
        HC1 = PlayerPrefs.GetInt("HIGHCALORIE1", HC1);
        HC2 = PlayerPrefs.GetInt("HIGHCALORIE2", HC2);
        HC3 = PlayerPrefs.GetInt("HIGHCALORIE3", HC3);
        HC4 = PlayerPrefs.GetInt("HIGHCALORIE4", HC4);
        HC5 = PlayerPrefs.GetInt("HIGHCALORIE5", HC5);
        //文字の初期化
        HCT1.SetActive(false);
        HCT2.SetActive(false);
        HCT3.SetActive(false);
        HCT4.SetActive(false);
        HCT5.SetActive(false);

    }

    
    public void Update()
    {
        //クリアしたステージによってのベストカロリー量の表示
        if (CalorieTEXT.StageInfor == 0)
        {
            RecoadStage1();
        }
        if (CalorieTEXT.StageInfor == 1)
        {
            RecoadStage2();
        }
        if (CalorieTEXT.StageInfor == 2)
        {
            RecoadStage3();
        }
        if (CalorieTEXT.StageInfor == 3)
        {
            RecoadStage4();
        }
        if (CalorieTEXT.StageInfor == 4)
        {
            RecoadStage5();
        }
    }

    public void RecoadStage1 ()
    {
        //文字の表示
        HCT1.SetActive(true);
        highcalorieTEXT.text = "カロリーの最高残量は" + HC1 + "です。".ToString();
        if (Input.GetKey(KeyCode.Space))//スペースが押されたらカロリー量のリセット
        {
            HC1 = 0;
            PlayerPrefs.SetInt("HIGHCALORIE1", HC1);
            PlayerPrefs.DeleteKey("HIGHCALORIE1");
        }
        //ハイカロリーより現在のカロリー量が上回ったとき（ステージ１）
        if (CalorieTEXT.CalorieTEXTInitival > HC1)
        {
            HC1 = (int)CalorieTEXT.CalorieTEXTInitival;//更新処理
            Messagetext.SetActive(true);// メッセージテキストを表示
            highcalorieTEXT.text = "カロリーの最高残量は" + HC1 + "です。".ToString();//ハイカロリー量の表示
            PlayerPrefs.SetInt("HIGHCALORIE1", HC1);//新しい記録をPlayerPrefsに記録
            //ランキングBGMをクリアにする
            SoundManager.plyingBGM = BGMType.Noue;
            //ハイスコアBGMを再生
            SoundManager.soundManager.PlayBgm(BGMType.Highscore);
            //スペースを押したら記録のリセット
            if (Input.GetKeyDown(KeyCode.Space))
            {
                HC1 = 0;
                PlayerPrefs.SetInt("HIGHCALORIE1", HC1);
                PlayerPrefs.DeleteKey("HIGHCALORIE1");
            }
        }
    }

    public void RecoadStage2()
    {
        //文字の表示
        HCT2.SetActive(true);
        highcalorieTEXT2.text = "カロリーの最高残量は" + HC2 + "です。".ToString();
        //スペースを押したら記録のリセット
        if (Input.GetKeyDown(KeyCode.Space))
        {
            HC2 = 0;
            PlayerPrefs.SetInt("HIGHCALORIE2", HC2);
            PlayerPrefs.DeleteKey("HIGHCALORIE2");
        }
        //ハイカロリーより現在のカロリー量が上回ったとき（ステージ２）
        if (CalorieTEXT.CalorieTEXTInitival > HC2)
        {
            HC2 = (int)CalorieTEXT.CalorieTEXTInitival;//更新処理
            Messagetext.SetActive(true);// メッセージテキストを表示
            highcalorieTEXT.text = "カロリーの最高残量は" + HC2 + "です。".ToString(); //ハイカロリー量の表示
            PlayerPrefs.SetInt("HIGHCALORIE2", HC2);//新しい記録をPlayerPrefsに記録
            //ランキングBGMをクリアにする
            SoundManager.plyingBGM = BGMType.Noue;
            //ハイスコアBGMを再生
            SoundManager.soundManager.PlayBgm(BGMType.Highscore);
            //スペースを押したら記録のリセット
            if (Input.GetKeyDown(KeyCode.Space))
            {
                HC2 = 0;
                PlayerPrefs.SetInt("HIGHCALORIE2", HC2);
                PlayerPrefs.DeleteKey("HIGHCALORIE2");
            }
        }
    }

    public void RecoadStage3()
    {
        //文字の表示
        HCT3.SetActive(true);
        highcalorieTEXT3.text = "カロリーの最高残量は" + HC3 + "です。".ToString();
        //スペースを押したら記録のリセット
        if (Input.GetKeyDown(KeyCode.Space))
        {
            HC3 = 0;
            PlayerPrefs.SetInt("HIGHCALORIE3", HC3);
            PlayerPrefs.DeleteKey("HIGHCALORIE3");
        }
        //ハイカロリーより現在のカロリー量が上回ったとき（ステージ３）
        if (CalorieTEXT.CalorieTEXTInitival > HC3)
        {
            HC3 = (int)CalorieTEXT.CalorieTEXTInitival;//更新処理
            Messagetext.SetActive(true);// メッセージテキストを表示
            highcalorieTEXT.text = "カロリーの最高残量は" + HC3 + "です。".ToString();//ハイカロリー量の表示
            PlayerPrefs.SetInt("HIGHCALORIE3", HC3);//新しい記録をPlayerPrefsに記録
            //ランキングBGMをクリアにする
            SoundManager.plyingBGM = BGMType.Noue;
            //ハイスコアBGMを再生
            SoundManager.soundManager.PlayBgm(BGMType.Highscore);
            //スペースを押したら記録のリセット
            if (Input.GetKeyDown(KeyCode.Space))
            {
                HC3 = 0;
                PlayerPrefs.SetInt("HIGHCALORIE3", HC3);
                PlayerPrefs.DeleteKey("HIGHCALORIE3");
            }
        }
    }

    public void RecoadStage4()
    {
        //文字の表示
        HCT4.SetActive(true);
        highcalorieTEXT4.text = "カロリーの最高残量は" + HC4 + "です。".ToString();
        //スペースを押したら記録のリセット
        if (Input.GetKeyDown(KeyCode.Space))
        {
            HC4 = 0;
            PlayerPrefs.SetInt("HIGHCALORIE4", HC4);
            PlayerPrefs.DeleteKey("HIGHCALORIE4");
        }
        //ハイカロリーより現在のカロリー量が上回ったとき（ステージ４）
        if (CalorieTEXT.CalorieTEXTInitival > HC4)
        {
            HC4 = (int)CalorieTEXT.CalorieTEXTInitival;//更新処理
            Messagetext.SetActive(true);// メッセージテキストを表示
            highcalorieTEXT.text = "カロリーの最高残量は" + HC4 + "です。".ToString();//ハイカロリー量の表示
            PlayerPrefs.SetInt("HIGHCALORIE4", HC4);//新しい記録をPlayerPrefsに記録
            //ランキングBGMをクリアにする
            SoundManager.plyingBGM = BGMType.Noue;
            //ハイスコアBGMを再生
            SoundManager.soundManager.PlayBgm(BGMType.Highscore);
            //スペースを押したら記録のリセット
            if (Input.GetKeyDown(KeyCode.Space))
            {
                HC4 = 0;
                PlayerPrefs.SetInt("HIGHCALORIE4", HC4);
                PlayerPrefs.DeleteKey("HIGHCALORIE4");
            }
        }
    }

    public void RecoadStage5()
    {
        //文字の表示
        HCT5.SetActive(true);
        highcalorieTEXT5.text = "カロリーの最高残量は" + HC5 + "です。".ToString();
        //スペースを押したら記録のリセット
        if (Input.GetKeyDown(KeyCode.Space))
        {
            HC5 = 0;
            PlayerPrefs.SetInt("HIGHCALORIE5", HC5);
            PlayerPrefs.DeleteKey("HIGHCALORIE5");
        }
        //ハイカロリーより現在のカロリー量が上回ったとき（ステージ５）
        if (CalorieTEXT.CalorieTEXTInitival > HC5)
        {
            HC5 = (int)CalorieTEXT.CalorieTEXTInitival;//更新処理
           Messagetext.SetActive(true);// メッセージテキストを表示
            highcalorieTEXT.text = "カロリーの最高残量は" + HC5 + "です。".ToString();//ハイカロリー量の表示
            PlayerPrefs.SetInt("HIGHCALORIE5", HC5);//新しい記録をPlayerPrefsに記録
            //ランキングBGMをクリアにする
            SoundManager.plyingBGM = BGMType.Noue;
            //ハイスコアBGMを再生
            SoundManager.soundManager.PlayBgm(BGMType.Highscore);
            //スペースを押したら記録のリセット
            if (Input.GetKeyDown(KeyCode.Space))
            {
                HC5 = 0;
                PlayerPrefs.SetInt("HIGHCALORIE5", HC5);
                PlayerPrefs.DeleteKey("HIGHCALORIE5");
            }
        }
    }

}

