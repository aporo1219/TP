using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class text : MonoBehaviour
{
    public Text textUI;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Hoge", 3);
        Invoke("Ho", 7);
        Invoke("og", 10);
        Invoke("Hog", 14);
        Invoke("ge", 18);
        Invoke("oge", 21);
        Invoke("machi", 24);
        Invoke("gema", 26);
    }

    void Hoge()
    {
        //3秒後テキスト変更
        textUI.text = "強制横スクロールだよ";
    }

    void Ho()
    {
        //7秒後テキスト変更
        textUI.text = "↑徐々にカロリーが減るので";
    }

    void og()
    {
        //10秒後テキスト変更
        textUI.text = "回復アイテムを拾おう";
    }

    void Hog()
    {
        //14秒後テキスト変更
        textUI.text = "これらのアイテムは避けよう";
    }

    void ge()
    {
        //18秒後テキスト変更
        textUI.text = "カロリーが0になったら";
    }

    void oge()
    {
        //21秒後テキスト変更
        textUI.text = "ゲームオーバーだよ";
    }

    void machi()
    {
        //24秒後テキスト変更
        textUI.text = "0にならないように";
    }

    void gema()
    {
        //26秒後テキスト変更
        textUI.text = "ゴールを目指そう！";
    }
}
