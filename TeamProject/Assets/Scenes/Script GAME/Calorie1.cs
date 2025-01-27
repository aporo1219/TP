using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Calorie1 : MonoBehaviour
{
    public Slider calobar;//カロリーバーの変数
    public int calo = 100;//最大値の変数
    private float currentTime = 0f;//経過時間
  
    
    // Start is called before the first frame update
    void Start()
    {
        //カロリーバーを見つける
        calobar = GameObject.Find("calobar").GetComponent<Slider>();
        
        //カロリーバーにカロリーの最大値を代入する
        calobar.maxValue = calo;

        calobar.value = 100;
       
    }

    // Update is called once per frame
    void Update()
    {
       //時間経過のカロリーバー減少の処理
        currentTime += Time.deltaTime;
       
        if (currentTime >=1.0f)
        {
            //2ずつ減っていく
            calobar.value -= 2;
            currentTime = 0;
        }
       
    }
     
     

    
   
}
