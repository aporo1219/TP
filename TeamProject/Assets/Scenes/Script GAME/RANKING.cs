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
    private int HC1;//ハイカロリー数の変数
    private int HC2;//ハイカロリー数の変数
    private int HC3;//ハイカロリー数の変数
    private int HC4;//ハイカロリー数の変数
    private int HC5;//ハイカロリー数の変数


    public void Start()
    {
        HC1 = PlayerPrefs.GetInt("HIGHCALORIE1", 0);
        HC1 = PlayerPrefs.GetInt("HIGHCALORIE2", 0);
        HC1 = PlayerPrefs.GetInt("HIGHCALORIE3", 0);
        HC1 = PlayerPrefs.GetInt("HIGHCALORIE4", 0);
        HC1 = PlayerPrefs.GetInt("HIGHCALORIE5", 0);

        //クリアしたステージによってのベストカロリー量の表示
        if (CalorieTEXT.StageInfor == 0)
        {
          highcalorieTEXT.text = "カロリーの最高残量は" + HC1 + "です。".ToString();
        }
        if (CalorieTEXT.StageInfor == 1)
        {
            highcalorieTEXT2.text = "カロリーの最高残量は" + HC2 + "です。".ToString();
        }
        if (CalorieTEXT.StageInfor == 2)
        {
            highcalorieTEXT3.text = "カロリーの最高残量は" + HC3 + "です。".ToString();
        }
        if (CalorieTEXT.StageInfor == 3)
        {
            highcalorieTEXT4.text = "カロリーの最高残量は" + HC4 + "です。".ToString();
        }
        if (CalorieTEXT.StageInfor == 4)
        {
            highcalorieTEXT5.text = "カロリーの最高残量は" + HC5 + "です。".ToString();
        }

    }

    public void SAVE()
    {
        PlayerPrefs.SetInt("HIGHCALORIE1", HC1);
        PlayerPrefs.SetInt("HIGHCALORIE2", HC2);
        PlayerPrefs.SetInt("HIGHCALORIE3", HC3);
        PlayerPrefs.SetInt("HIGHCALORIE4", HC4);
        PlayerPrefs.SetInt("HIGHCALORIE5", HC5);
    }
    public void Update()
    {
        //ハイカロリーより現在のカロリー量が上回ったとき
        if (CalorieTEXT.CalorieTEXTInitival > HC1)
        {
            HC1 = (int)CalorieTEXT.CalorieTEXTInitival;//更新処理
            highcalorieTEXT.text = "カロリーの最高残量は" + HC1 + "です。".ToString();//ハイカロリー量の表示

            if (Input.GetKeyDown(KeyCode.Space))
            {
                RESET1();//スペースが押されたらカロリー量のリセット
            }

            
        }
        //ハイカロリーより現在のカロリー量が上回ったとき
        if (CalorieTEXT.CalorieTEXTInitival > HC2)
        {
            HC2 = (int)CalorieTEXT.CalorieTEXTInitival;//更新処理
            highcalorieTEXT.text = "カロリーの最高残量は" + HC2 + "です。".ToString(); //ハイカロリー量の表示

            if (Input.GetKeyDown(KeyCode.Space))
            {
                RESET2();//スペースが押されたらカロリー量のリセット
            }
        }
        //ハイカロリーより現在のカロリー量が上回ったとき
        if (CalorieTEXT.CalorieTEXTInitival > HC3)
        {
            HC3 = (int)CalorieTEXT.CalorieTEXTInitival;//更新処理
            highcalorieTEXT.text = "カロリーの最高残量は" + HC3 + "です。".ToString();//ハイカロリー量の表示

            if (Input.GetKeyDown(KeyCode.Space))
            {
                RESET3();//スペースが押されたらカロリー量のリセット
            }
        }
        //ハイカロリーより現在のカロリー量が上回ったとき
        if (CalorieTEXT.CalorieTEXTInitival > HC4)
        {
            HC4 = (int)CalorieTEXT.CalorieTEXTInitival;//更新処理
            highcalorieTEXT.text = "カロリーの最高残量は" + HC4 + "です。".ToString();//ハイカロリー量の表示

            if (Input.GetKeyDown(KeyCode.Space))
            {
                RESET4();//スペースが押されたらカロリー量のリセット
            }
        }
        //ハイカロリーより現在のカロリー量が上回ったとき
        if (CalorieTEXT.CalorieTEXTInitival > HC5)
        {
            HC5 = (int)CalorieTEXT.CalorieTEXTInitival;//更新処理
            highcalorieTEXT.text = "カロリーの最高残量は" + HC5 + "です。".ToString();//ハイカロリー量の表示

            if (Input.GetKeyDown(KeyCode.Space))
            {
                RESET5();//スペースが押されたらカロリー量のリセット
            }
        }
        

    }

    public void RESET1()
    {
        PlayerPrefs.DeleteKey("HIGHCALORIE1");
    }

    public void RESET2()
    {
        PlayerPrefs.DeleteKey("HIGHCALORIE2");
    }

    public void RESET3()
    {
       PlayerPrefs.DeleteKey("HIGHCALORIE3"); 
    }

    public void RESET4()
    {
      PlayerPrefs.DeleteKey("HIGHCALORIE4");
    }
 
    public void RESET5()
    {
      PlayerPrefs.DeleteKey("HIGHCALORIE5");
    }



}

