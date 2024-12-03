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
        HC1 = PlayerPrefs.GetInt("HIGHCALORIE1", HC1);
        HC2 = PlayerPrefs.GetInt("HIGHCALORIE2", HC2);
        HC3 = PlayerPrefs.GetInt("HIGHCALORIE3", HC3);
        HC4 = PlayerPrefs.GetInt("HIGHCALORIE4", HC4);
        HC5 = PlayerPrefs.GetInt("HIGHCALORIE5", HC5);

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
            HCT1.SetActive(true);
            highcalorieTEXT.text = "カロリーの最高残量は" + HC1 + "です。".ToString();
            PlayerPrefs.SetInt("HIGHCALORIE1", HC1);
            PlayerPrefs.Save();//スコアの保存関数
            if (Input.GetKeyDown(KeyCode.Space))//スペースが押されたらカロリー量のリセット
            {
                PlayerPrefs.DeleteKey("HIGHCALORIE1");
            }
        }
        if (CalorieTEXT.StageInfor == 1)
        {
            HCT2.SetActive(true);
            highcalorieTEXT2.text = "カロリーの最高残量は" + HC2 + "です。".ToString();
            PlayerPrefs.SetInt("HIGHCALORIE12", HC2);
            PlayerPrefs.Save();//スコアの保存関数
            if (Input.GetKeyDown(KeyCode.Space))
            {
               
            }
        }
        if (CalorieTEXT.StageInfor == 2)
        {
            HCT3.SetActive(true);
            highcalorieTEXT3.text = "カロリーの最高残量は" + HC3 + "です。".ToString();
            PlayerPrefs.SetInt("HIGHCALORIE3", HC3);
            PlayerPrefs.Save();//スコアの保存関数
            if (Input.GetKeyDown(KeyCode.Space))
            {
                
            }
        }
        if (CalorieTEXT.StageInfor == 3)
        {
            HCT4.SetActive(true);
            highcalorieTEXT4.text = "カロリーの最高残量は" + HC4 + "です。".ToString();
            PlayerPrefs.SetInt("HIGHCALORIE4", HC4);
            PlayerPrefs.Save();//スコアの保存関数
            if (Input.GetKeyDown(KeyCode.Space))
            {
                
            }
        }
        if (CalorieTEXT.StageInfor == 4)
        {
            HCT5.SetActive(true);
            highcalorieTEXT5.text = "カロリーの最高残量は" + HC5 + "です。".ToString();
            PlayerPrefs.SetInt("HIGHCALORIE5", HC5);
            PlayerPrefs.Save();//スコアの保存関数
            if (Input.GetKeyDown(KeyCode.Space))
            {

            }
        }
        //ハイカロリーより現在のカロリー量が上回ったとき
        if (CalorieTEXT.CalorieTEXTInitival > HC1)
        {
            HC1 = (int)CalorieTEXT.CalorieTEXTInitival;//更新処理
            highcalorieTEXT.text = "カロリーの最高残量は" + HC1 + "です。".ToString();//ハイカロリー量の表示


            if (Input.GetKeyDown(KeyCode.Space))
            {
               
            }

        }
        //ハイカロリーより現在のカロリー量が上回ったとき
        if (CalorieTEXT.CalorieTEXTInitival > HC2)
        {
            HC2 = (int)CalorieTEXT.CalorieTEXTInitival;//更新処理
            highcalorieTEXT.text = "カロリーの最高残量は" + HC2 + "です。".ToString(); //ハイカロリー量の表示

            if (Input.GetKeyDown(KeyCode.Space))
            {
                PlayerPrefs.DeleteKey("HIGHCALORIE1");
            }
        }
        //ハイカロリーより現在のカロリー量が上回ったとき
        if (CalorieTEXT.CalorieTEXTInitival > HC3)
        {
            HC3 = (int)CalorieTEXT.CalorieTEXTInitival;//更新処理
            highcalorieTEXT.text = "カロリーの最高残量は" + HC3 + "です。".ToString();//ハイカロリー量の表示

            if (Input.GetKeyDown(KeyCode.Space))
            {
                
            }
        }
        //ハイカロリーより現在のカロリー量が上回ったとき
        if (CalorieTEXT.CalorieTEXTInitival > HC4)
        {
            HC4 = (int)CalorieTEXT.CalorieTEXTInitival;//更新処理
            highcalorieTEXT.text = "カロリーの最高残量は" + HC4 + "です。".ToString();//ハイカロリー量の表示

            if (Input.GetKeyDown(KeyCode.Space))
            {
                
            }
        }
        //ハイカロリーより現在のカロリー量が上回ったとき
        if (CalorieTEXT.CalorieTEXTInitival > HC5)
        {
            HC5 = (int)CalorieTEXT.CalorieTEXTInitival;//更新処理
            highcalorieTEXT.text = "カロリーの最高残量は" + HC5 + "です。".ToString();//ハイカロリー量の表示

            if (Input.GetKeyDown(KeyCode.Space))
            {
                
            }
        }
        

    }




}

