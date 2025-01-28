using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Recordrenewal :RANKING
{
    //ハイスコア更新時にメッセージを出す処理
    public Text Messagetext;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //クリアしたステージによってのベストカロリー量の表示
        if (CalorieTEXT.StageInfor == 0)
        {
            Text1();
        }
        if (CalorieTEXT.StageInfor == 1)
        {
            Text2();
        }
        if (CalorieTEXT.StageInfor == 2)
        {
            Text3();
        }
        if (CalorieTEXT.StageInfor == 3)
        {
            Text4();
        }
        if (CalorieTEXT.StageInfor == 4)
        {
            Text5();
        }
    }

    void Text1()
    {
        //RANKINGステージ1の変数よりカロリーテキストの数字が大きいとテキストを表示し条件を満たしてない場合テキストを非表示にする
        if (CalorieTEXT.CalorieTEXTInitival > RANKING.HC1)
        {
            Messagetext.enabled = true;// テキストを表示
        }
        else
        {
            Messagetext.enabled = false;// テキストを非表示
        }
    }

    void Text2()
    {
        //RANKINGステージ2の変数よりカロリーテキストの数字が大きいとテキストを表示し条件を満たしてない場合テキストを非表示にする
        if (CalorieTEXT.CalorieTEXTInitival > RANKING.HC2)
        {
            Messagetext.enabled = true;// テキストを表示
        }
        else
        {
            Messagetext.enabled = false;// テキストを非表示
        }
    }

    void Text3()
    {
        //RANKINGステージ3の変数よりカロリーテキストの数字が大きいとテキストを表示し条件を満たしてない場合テキストを非表示にする
        if (CalorieTEXT.CalorieTEXTInitival > RANKING.HC3)
        {
            Messagetext.enabled = true;// テキストを表示
        }
        else
        {
            Messagetext.enabled = false;// テキストを非表示
        }
    }

    void Text4()
    {
        //RANKINGステージ4の変数よりカロリーテキストの数字が大きいとテキストを表示し条件を満たしてない場合テキストを非表示にする
        if (CalorieTEXT.CalorieTEXTInitival > RANKING.HC4)
        {
            Messagetext.enabled = true;// テキストを表示
        }
        else
        {
            Messagetext.enabled = false;// テキストを非表示
        }
    }

    void Text5()
    {
        //RANKINGステージの変数よりカロリーテキストの数字が大きいとテキストを表示し条件を満たしてない場合テキストを非表示にする
        if (CalorieTEXT.CalorieTEXTInitival > RANKING.HC5)
        {
            Messagetext.enabled = true;// テキストを表示
        }
        else
        {
            Messagetext.enabled = false;// テキストを非表示
        }
    }

}