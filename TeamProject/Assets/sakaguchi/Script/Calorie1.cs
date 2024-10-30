using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Calorie1 : MonoBehaviour
{
    private
     float CalorieM;//カロリーの初期値
    float CalorieO;//障害物による減少
    float CalorieS;//スイーツによる増加
    public
     Text CalorieText;//カロリーの文字の変数

    void Start()
    {
        CalorieM = 10.0f;//はじめを100
    }

    void Update()
    {
        CalorieText.text = "Calorie:" + CalorieM.ToString();//カロリーのテキスト文字をカロリーの初期値におく
        CalorieM -= Time.deltaTime * 2;//時間による減少の処理
        if (CalorieM <= 0.0f)
        {
            SceneManager.LoadScene("GameOver");
        }
    }


}

