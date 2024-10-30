using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Cleark: MonoBehaviour
{
    public GameObject objectToShow;
    public float displayDelay = 2.0f; // 表示までの待機時間（秒）

    private float timer;
    private bool isDisplayed;

    

    private void Start()
    {
        // 初期化（出現）
        timer = 0.0f;
        isDisplayed = false;
        objectToShow.SetActive(false); // ゲーム開始時にオブジェクトを非表示にする

       

    }

    private void Update()
    {
        //出現の処理
        if (!isDisplayed)
        {
            timer += Time.deltaTime; // 経過時間をカウント

            if (timer >= displayDelay)
            {
                // 一定時間経過したらオブジェクトを表示
                objectToShow.SetActive(true);
                isDisplayed = true;
               
            }
        }
    }
}

