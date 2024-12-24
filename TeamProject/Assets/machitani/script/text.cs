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
        Invoke("TutorialText", 3);
        Invoke("Tuto", 7);
        Invoke("rial", 10);
        Invoke("Tutorial", 14);
        Invoke("rialText", 18);
        Invoke("Tutor", 21);
        Invoke("Turia", 24);
        Invoke("TutorialTex", 26);
    }

    void TutorialText()
    {
        //3秒後テキスト変更
        textUI.text = "強制横スクロールだよ";
    }

    void Tuto()
    {
        //7秒後テキスト変更
        textUI.text = "↑徐々にカロリーが減るので";
    }

    void rial()
    {
        //10秒後テキスト変更
        textUI.text = "回復アイテムを拾おう";
    }

    void Tutorial()
    {
        //14秒後テキスト変更
        textUI.text = "これらのアイテムは避けよう";
    }

    void rialText()
    {
        //18秒後テキスト変更
        textUI.text = "カロリーが0になったら";
    }

    void Tutor()
    {
        //21秒後テキスト変更
        textUI.text = "ゲームオーバーだよ";
    }

    void Turia()
    {
        //24秒後テキスト変更
        textUI.text = "0にならないように";
    }

    void TutorialTex()
    {
        //26秒後テキスト変更
        textUI.text = "ゴールを目指そう！";
    }
}
