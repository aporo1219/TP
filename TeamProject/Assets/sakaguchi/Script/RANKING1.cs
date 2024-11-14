using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class RANKING1 : MonoBehaviour
{
    public Text highcalorieTEXT;//ハイカロリー数を表示するTEXT
    private int HC;//ハイカロリー数の変数



    public void Start()
    {
        HC = PlayerPrefs.GetInt("HIGHCALORIE", 0);
        highcalorieTEXT.text = "カロリーの最高残量は" + HC + "です。".ToString();
    }

    public void SAVE()
    {
        PlayerPrefs.SetInt("HIGHCALORIE", HC);
    }
    public void Update()
    {
        //ハイカロリーより現在のカロリー量が上回ったとき
        if (CalorieTEXT.CalorieTEXTInitival > HC)
        {
            HC = (int)CalorieTEXT.CalorieTEXTInitival;//更新処理
            highcalorieTEXT.text = "カロリーの最高残量は" + HC + "です。".ToString();

            //ハイカロリー量の表示
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RESET();//スペースが押されたらカロリー量のリセット
        }

    }

    public void RESET()
    {
        PlayerPrefs.DeleteAll();
    }




}

