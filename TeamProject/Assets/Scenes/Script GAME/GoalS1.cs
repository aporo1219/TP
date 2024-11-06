using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GoalS1 : MonoBehaviour
{
    public GameObject objectToShowGS;
    public float displayDelayGS = 2.0f; // 表示までの待機時間（秒）

    private float timerGS;
    private bool isDisplayedGS;



    private void Start()
    {
        // 初期化（出現）
        timerGS = 0.0f;
        isDisplayedGS = false;
        objectToShowGS.SetActive(false); // ゲーム開始時にオブジェクトを非表示にする



    }

    private void Update()
    {
        //出現の処理
        if (!isDisplayedGS)
        {
            timerGS += Time.deltaTime; // 経過時間をカウント

            if (timerGS >= displayDelayGS)
            {
                // 一定時間経過したらオブジェクトを表示
                objectToShowGS.SetActive(true);
                isDisplayedGS = true;

            }
        }
    }
}

