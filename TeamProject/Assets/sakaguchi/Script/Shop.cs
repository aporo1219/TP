using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Shop : MonoBehaviour
{
    public GameObject objectToShowS;
    public float displayDelayS = 30.0f; // 表示までの待機時間（秒）

    private float timerS;
    private bool isDisplayedS;



    private void Start()
    {
        // 初期化（出現）
        timerS = 0.0f;
        isDisplayedS = false;
        objectToShowS.SetActive(false); // ゲーム開始時にオブジェクトを非表示にする



    }

    private void Update()
    {
        //出現の処理
        if (!isDisplayedS)
        {
            timerS += Time.deltaTime; // 経過時間をカウント

            if (timerS >= displayDelayS)
            {
                // 一定時間経過したらオブジェクトを表示
                objectToShowS.SetActive(true);
                isDisplayedS= true;

            }
        }
    }
}

