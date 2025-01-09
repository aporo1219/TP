using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Cleark1: MonoBehaviour
{
    public GameObject ObjectToShowCleark;
    public float DisplayDelay = 2.0f; // 表示までの待機時間（秒）
    private float TimerCleark;
    private bool IsDisplayedCleark;

    

    private void Start()
    {
        // 初期化（出現）
        TimerCleark = 0.0f;
        IsDisplayedCleark = false;
        ObjectToShowCleark.SetActive(false); // ゲーム開始時にオブジェクトを非表示にする

       

    }

    private void Update()
    {
        //出現の処理
        if (!IsDisplayedCleark)
        {
            TimerCleark += Time.deltaTime; // 経過時間をカウント

            if (TimerCleark >= DisplayDelay)
            {
                // 一定時間経過したらオブジェクトを表示
                ObjectToShowCleark.SetActive(true);
                IsDisplayedCleark = true;
               
            }
        }
    }
}

