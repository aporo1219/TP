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
        textUI.text = "強制横スクロールだよ";
    }

    void Ho()
    {
        textUI.text = "↑徐々にカロリーが減るので";
    }

    void og()
    {
        textUI.text = "回復アイテムを拾おう";
    }

    void Hog()
    {
        textUI.text = "これらのアイテムは避けよう";
    }

    void ge()
    {
        textUI.text = "カロリーが0になったら";
    }

    void oge()
    {
        textUI.text = "ゲームオーバーだよ";
    }

    void machi()
    {
        textUI.text = "0にならないように";
    }

    void gema()
    {
        textUI.text = "ゴールを目指そう！";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
