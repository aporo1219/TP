using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Result : MonoBehaviour
{
    //クリア画面のスイーツオブジェクトの変数
    [SerializeField] public GameObject M;
    [SerializeField] public GameObject Pan;
    [SerializeField] public GameObject Par;
    [SerializeField] public GameObject C;
    [SerializeField] public GameObject D;

    //テキストの変数
    public Text resultcalo;


    void Start()
    {
        //文字の初期化
        M.SetActive(false);
        Pan.SetActive(false);
        Par.SetActive(false);
        C.SetActive(false);
        D.SetActive(false);
    }

     void Update()
    {
        //文字の表示
        resultcalo.text = "カロリーの残量は" + CalorieTEXT.CalorieTEXTInitival + "kcalです。";//文字の表示

        if(CalorieTEXT.StageInfor == 0)//ステージ1のスイーツの表示
        {
            D.SetActive(true);
        }
        if (CalorieTEXT.StageInfor == 1)//ステージ2のスイーツの表示
        {
            M.SetActive(true);
        }
        if (CalorieTEXT.StageInfor == 2)//ステージ3のスイーツの表示
        {
            Par.SetActive(true);
        }
        if (CalorieTEXT.StageInfor == 3)//ステージ4のスイーツの表示
        {
            Pan.SetActive(true);
        }
        if (CalorieTEXT.StageInfor == 4)//ステージ5のスイーツの表示
        {
            C.SetActive(true);
        }
    }
}