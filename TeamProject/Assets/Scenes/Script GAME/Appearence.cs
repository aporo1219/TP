using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Appearence : MonoBehaviour
{
    //唐辛子
    public GameObject objectToShowchili;
    public float displayDelaychili = 30.0f; // 表示までの待機時間（秒）
    private float timerchili;
    private bool isDisplayedchili;
   //チョコレート
    public GameObject objectToShowchoco;
    public float displayDelaychoco = 30.0f; // 表示までの待機時間（秒）
    private float timerchoco; 
    private bool isDisplayedchoco;
    //クッキー
    public GameObject objectToShowcookie;
    public float displayDelaycookie = 30.0f; // 表示までの待機時間（秒）
    private float timercookie;
    private bool isDisplayedcookie;
    //ダンベル
    public GameObject objectToShowdombbell;
    public float displayDelaydombbell = 30.0f; // 表示までの待機時間（秒）
    private float timerdombbell;
    private bool isDisplayedombbell;
    //落とし穴
    public GameObject objectToShowpitfall;
    public float displayDelaypitfall = 30.0f; // 表示までの待機時間（秒）
    private float timerpitfall;
    private bool isDisplayedpitfall;
    //プリン
    public GameObject objectToShowpudding;
    public float displayDelaypudding = 30.0f; // 表示までの待機時間（秒）
    private float timerpudding;
    private bool isDisplayedpudding;
    private void Start()
    {
        // 初期化（出現）
        //唐辛子
        timerchili = 0.0f;
        isDisplayedchili = false;
        objectToShowchili.SetActive(false); // ゲーム開始時にオブジェクトを非表示にする
        //チョコレート
        timerchoco = 0.0f;
        isDisplayedchoco = false;
        objectToShowchoco.SetActive(false); // ゲーム開始時にオブジェクトを非表示
        //クッキー                                
        timercookie = 0.0f;
        isDisplayedcookie = false;
        objectToShowcookie.SetActive(false); // ゲーム開始時にオブジェクトを非表示にする
        // ダンベル                                                           
        timerdombbell = 0.0f;
        isDisplayedombbell = false;
        objectToShowdombbell.SetActive(false); // ゲーム開始時にオブジェクトを非表示にする
        //落とし穴                                                                                                 
        timerpitfall = 0.0f;
        isDisplayedpitfall = false;
        objectToShowpitfall.SetActive(false); // ゲーム開始時にオブジェクトを非表示にする
        //プリン                                                                                               
        timerpudding = 0.0f;
        isDisplayedpudding = false;
        objectToShowpudding.SetActive(false); // ゲーム開始時にオブジェクトを非表示にする
    }

    private void Update()
    {
        //出現の処理
        //唐辛子
        if (!isDisplayedchili)
        {
            timerchili += Time.deltaTime; // 経過時間をカウント

            if (timerchili >= displayDelaychili)
            {
                // 一定時間経過したらオブジェクトを表示
                objectToShowchili.SetActive(true);
                isDisplayedchili = true;

            }
        }
        //チョコ
        if (!isDisplayedchoco)
        {
            timerchoco += Time.deltaTime; // 経過時間をカウント

            if (timerchoco >= displayDelaychoco)
            {
                // 一定時間経過したらオブジェクトを表示
                objectToShowchoco.SetActive(true);
                isDisplayedchoco = true;

            }
        }
        //クッキー
        if (!isDisplayedcookie)
        {
            timercookie += Time.deltaTime; // 経過時間をカウント

            if (timercookie >= displayDelaycookie)
            {
                // 一定時間経過したらオブジェクトを表示
                objectToShowcookie.SetActive(true);
                isDisplayedcookie = true;

            }
        }
        //ダンベル
        if (!isDisplayedombbell)
        {
            timerdombbell += Time.deltaTime; // 経過時間をカウント

            if (timerdombbell >= displayDelaydombbell)
            {
                // 一定時間経過したらオブジェクトを表示
                objectToShowdombbell.SetActive(true);
                isDisplayedombbell = true;

            }
        }
        //落とし穴
        if (!isDisplayedpitfall)
        {
            timerpitfall += Time.deltaTime; // 経過時間をカウント

            if (timerpitfall >= displayDelaypitfall)
            {
                // 一定時間経過したらオブジェクトを表示
                objectToShowpitfall.SetActive(true);
                isDisplayedpitfall = true;

            }
        }
        //プリン
        if (!isDisplayedpudding)
        {
            timerpudding += Time.deltaTime; // 経過時間をカウント

            if (timerpudding >= displayDelaypudding)
            {
                // 一定時間経過したらオブジェクトを表示
                objectToShowpudding.SetActive(true);
                isDisplayedpudding = true;

            }
        }
    }
}

