using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Result : MonoBehaviour
{
    //クリア画面のスイーツオブジェクトの変数
    [SerializeField] public GameObject Macaron;
    [SerializeField] public GameObject Pancake;
    [SerializeField] public GameObject Parfait;
    [SerializeField] public GameObject Cake;
    [SerializeField] public GameObject Dounatu;

    //テキストの変数
    public Text resultcalo;

    
    


    void Start()
    {
        //文字の初期化
        Macaron.SetActive(false);
        Pancake.SetActive(false);
        Parfait.SetActive(false);
        Cake.SetActive(false);
        Dounatu.SetActive(false);
    }

     void Update()
    {
       
        //文字の表示
        resultcalo.text = "カロリーの残量は" + CalorieTEXT.CalorieTEXTInitival + "kcalです。";
　　　　 
        if(CalorieTEXT.StageInfor == 0)//ステージ1のスイーツの表示
        {
            Dounatu.SetActive(true);
        }
        if (CalorieTEXT.StageInfor == 1)//ステージ2のスイーツの表示
        {
            Macaron.SetActive(true);
        }
        if (CalorieTEXT.StageInfor == 2)//ステージ3のスイーツの表示
        {
            Parfait.SetActive(true);
        }
        if (CalorieTEXT.StageInfor == 3)//ステージ4のスイーツの表示
        {
            Pancake.SetActive(true);
        }
        if (CalorieTEXT.StageInfor == 4)//ステージ5のスイーツの表示
        {
            Cake.SetActive(true);
        }
   　}

}

