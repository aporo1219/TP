using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RESULT1 : MonoBehaviour
{
    //スイーツの表示(マカロン）
    public GameObject objectToShowM;
   
    //(パンケーキ)
    public GameObject objectToShowPancake;
    
    //(パフェ）
    public GameObject objectToShowParfait;
    
    //(ケーキ)
    public GameObject objectToShowC;
   
    //(プリン)
    public GameObject objectToShowPudding;
  

    public Text calorieresult;//テキストの表示
    // Start is called before the first frame update
    void Start()
    {
        //マカロン
        
        objectToShowM.SetActive(true);
        //パンケーキ
        
        objectToShowPancake.SetActive(false);
        //パフェ
        
        objectToShowParfait.SetActive(false);
        //ケーキ
        
        objectToShowC.SetActive(false);
        //プリン
        
        objectToShowPudding.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        calorieresult.text = "カロリーは" + CalorieTEXT.CalorieTEXTInitival + "Kcal残ったよ。".ToString();//カロリーのテキスト文字をカロリーの初期値におく
        if(SceneManager.GetActiveScene().name == "stage2")
        {
            STAGE2GC();
        }
        if (SceneManager.GetActiveScene().name == "stage3")
        {
            STAGE3GC();
        }
        if (SceneManager.GetActiveScene().name == "stage4")
        {
            STAGE4GC();
        }
        if (SceneManager.GetActiveScene().name == "stage5")
        {
            STAGE5GC();
        }

    }
    void STAGE2GC()//ステージ２をクリアしたらプリンの表示
    {
        objectToShowM.SetActive(false);
        objectToShowPudding.SetActive(true);
    }
    void STAGE3GC()//ステージ3をクリアしたらパフェの表示
    {
        objectToShowM.SetActive(false);
        objectToShowParfait.SetActive(true);
    }

    void STAGE4GC()//ステージ4をクリアしたらパンケーキの表示
    {
        objectToShowM.SetActive(false);
        objectToShowPancake.SetActive(true);
    }

    void STAGE5GC()//ステージ5をクリアしたらケーキの表示
    {
        objectToShowM.SetActive(false);
        objectToShowC.SetActive(true);
    }
}
