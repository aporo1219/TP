using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AppearenceOne : MonoBehaviour
{
    //もの
    public GameObject objectToShowThing;//オブジェクトの変数
    public float displayDelayThing = 30.0f; // 表示までの待機時間（秒）
    private float timerThing;//現れる計算用の変数
    private bool isDisplayedThing;
   
    

   

    private void Start()
    {
        // 初期化（出現）
        //もの
        timerThing = 0.0f;
        isDisplayedThing = false;
        objectToShowThing.SetActive(false); // ゲーム開始時にオブジェクトを非表示にする
        GameObject dumbbell = GameObject.FindWithTag("dumbbell");
      
    }

    private void Update()
    {
        //出現の処理
        //もの
        if (!isDisplayedThing)
        {
             Thing();
        }
    }

    //物の処理の関数
    public void Thing()
    {
        timerThing += Time.deltaTime; // 経過時間をカウント

        if (timerThing >= displayDelayThing)
        {
            // 一定時間経過したらオブジェクトを表示
            objectToShowThing.SetActive(true);
            isDisplayedThing = true;
            
        }
    }

   
}

