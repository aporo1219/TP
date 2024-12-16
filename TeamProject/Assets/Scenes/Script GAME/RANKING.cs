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
    public GameObject HCT1;//ハイカロリー数を表示するTEXTを表示、非表示
    public GameObject HCT2;//ハイカロリー数を表示するTEXTを表示、非表示
    public GameObject HCT3;//ハイカロリー数を表示するTEXTを表示、非表示
    public GameObject HCT4;//ハイカロリー数を表示するTEXTを表示、非表示
    public GameObject HCT5;//ハイカロリー数を表示するTEXTを表示、非表示
    private int HC1;//ハイカロリー数の変数
    private int HC2;//ハイカロリー数の変数
    private int HC3;//ハイカロリー数の変数
    private int HC4;//ハイカロリー数の変数
    private int HC5;//ハイカロリー数の変数


    public void Start()
    {
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
            //文字の表示
            HCT1.SetActive(true);
            highcalorieTEXT.text = "カロリーの最高残量は" + HC1 + "です。".ToString();
           if (Input.GetKey(KeyCode.Space))//スペースが押されたらカロリー量のリセット
           {
                PlayerPrefs.DeleteKey("HIGHCALORIE1");
           }
           
           
        }
        if (CalorieTEXT.StageInfor == 1)
        {
            //文字の表示
            HCT2.SetActive(true);
            highcalorieTEXT2.text = "カロリーの最高残量は" + HC2 + "です。".ToString();
            if (Input.GetKeyDown(KeyCode.Space))
            {
                PlayerPrefs.DeleteKey("HIGHCALORIE2");
            }
        }
        if (CalorieTEXT.StageInfor == 2)
        {
            //文字の表示
            HCT3.SetActive(true);
            highcalorieTEXT3.text = "カロリーの最高残量は" + HC3 + "です。".ToString();
            if (Input.GetKeyDown(KeyCode.Space))
            {
                PlayerPrefs.DeleteKey("HIGHCALORIE3");
            }
        }
        if (CalorieTEXT.StageInfor == 3)
        {
            //文字の表示
            HCT4.SetActive(true);
            highcalorieTEXT4.text = "カロリーの最高残量は" + HC4 + "です。".ToString();
            if (Input.GetKeyDown(KeyCode.Space))
            {
                PlayerPrefs.DeleteKey("HIGHCALORIE4");
            }
        }
        if (CalorieTEXT.StageInfor == 4)
        {
            //文字の表示
            HCT5.SetActive(true);
            highcalorieTEXT5.text = "カロリーの最高残量は" + HC5 + "です。".ToString();
            if (Input.GetKeyDown(KeyCode.Space))
            {
                PlayerPrefs.DeleteKey("HIGHCALORIE5");
            }
        }
        //ハイカロリーより現在のカロリー量が上回ったとき（ステージ１）
        if (CalorieTEXT.CalorieTEXTInitival > HC1)
        {
            HC1 = (int)CalorieTEXT.CalorieTEXTInitival;//更新処理
            highcalorieTEXT.text = "カロリーの最高残量は" + HC1 + "です。".ToString();//ハイカロリー量の表示
            PlayerPrefs.SetInt("HIGHCALORIE1", HC1); 
            if (Input.GetKeyDown(KeyCode.Space))
            {
                PlayerPrefs.DeleteKey("HIGHCALORIE1");
            }
        }
        //ハイカロリーより現在のカロリー量が上回ったとき（ステージ２）
        if (CalorieTEXT.CalorieTEXTInitival > HC2)
        {
            HC2 = (int)CalorieTEXT.CalorieTEXTInitival;//更新処理
            highcalorieTEXT.text = "カロリーの最高残量は" + HC2 + "です。".ToString(); //ハイカロリー量の表示
            PlayerPrefs.SetInt("HIGHCALORIE2", HC2); 
            if (Input.GetKeyDown(KeyCode.Space))
            {
                PlayerPrefs.DeleteKey("HIGHCALORIE2");
            }
        }
        //ハイカロリーより現在のカロリー量が上回ったとき（ステージ３）
        if (CalorieTEXT.CalorieTEXTInitival > HC3)
        {
            HC3 = (int)CalorieTEXT.CalorieTEXTInitival;//更新処理
            highcalorieTEXT.text = "カロリーの最高残量は" + HC3 + "です。".ToString();//ハイカロリー量の表示
            PlayerPrefs.SetInt("HIGHCALORIE3", HC3); 
            if (Input.GetKeyDown(KeyCode.Space))
            {
                PlayerPrefs.DeleteKey("HIGHCALORIE3");
            }
        }
        //ハイカロリーより現在のカロリー量が上回ったとき（ステージ４）
        if (CalorieTEXT.CalorieTEXTInitival > HC4)
        {
            HC4 = (int)CalorieTEXT.CalorieTEXTInitival;//更新処理
            highcalorieTEXT.text = "カロリーの最高残量は" + HC4 + "です。".ToString();//ハイカロリー量の表示
            PlayerPrefs.SetInt("HIGHCALORIE4", HC4); 
            if (Input.GetKeyDown(KeyCode.Space))
            {
                PlayerPrefs.DeleteKey("HIGHCALORIE4");
            }
        }
        //ハイカロリーより現在のカロリー量が上回ったとき（ステージ５）
        if (CalorieTEXT.CalorieTEXTInitival > HC5)
        {
            HC5 = (int)CalorieTEXT.CalorieTEXTInitival;//更新処理
            highcalorieTEXT.text = "カロリーの最高残量は" + HC5 + "です。".ToString();//ハイカロリー量の表示
            PlayerPrefs.SetInt("HIGHCALORIE5", HC5); 
            if (Input.GetKeyDown(KeyCode.Space))
            {
                PlayerPrefs.DeleteKey("HIGHCALORIE5");
            }
        }
        

    }




}

