using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Shop1 : MonoBehaviour
{
    public GameObject ObjectToShowShop;
    public float DisplayDelayShop = 30.0f; // 表示までの待機時間（秒）

    private float TimerShop;
    private bool IsDisplayedShop;



    private void Start()
    {
        // 初期化（出現）
        TimerShop = 0.0f;
        IsDisplayedShop = false;
        ObjectToShowShop.SetActive(false); // ゲーム開始時にオブジェクトを非表示にする



    }

    private void Update()
    {
        //出現の処理
        if (!IsDisplayedShop)
        {
            TimerShop += Time.deltaTime; // 経過時間をカウント

            if (TimerShop >= DisplayDelayShop)
            {
                // 一定時間経過したらオブジェクトを表示
                ObjectToShowShop.SetActive(true);
                IsDisplayedShop= true;

            }
        }
    }
}

