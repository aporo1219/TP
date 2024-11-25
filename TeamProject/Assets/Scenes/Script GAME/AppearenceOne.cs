using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AppearenceOne : MonoBehaviour
{
    //もの
    public GameObject objectToShowany;
    public float displayDelayany = 30.0f; // 表示までの待機時間（秒）
    private float timerany;
    private bool isDisplayedany;
   
    private void Start()
    {
        // 初期化（出現）
        //もの
        timerany = 0.0f;
        isDisplayedany = false;
        objectToShowany.SetActive(false); // ゲーム開始時にオブジェクトを非表示にする
    }

    private void Update()
    {
        //出現の処理
        //もの
        if (!isDisplayedany)
        {
            timerany += Time.deltaTime; // 経過時間をカウント

            if (timerany>= displayDelayany)
            {
                // 一定時間経過したらオブジェクトを表示
                objectToShowany.SetActive(true);
                isDisplayedany = true;

            }
        }
        
    }
}

