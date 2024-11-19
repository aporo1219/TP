using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RESULT1 : MonoBehaviour
{
    //スイーツの表示(マカロン）
    public GameObject objectToShowM;
    private bool isDisplayedM;
    //(パンケーキ)
    public GameObject objectToShowPancake;
    private bool isDisplayedPancake;
    //(パフェ）
    public GameObject objectToShowParfait;
    private bool isDisplayedParfait;
    //(ケーキ)
    public GameObject objectToShowC;
    private bool isDisplayedC;
    //()
    public GameObject objectToShow;
    private bool isDisplayed;
    public Text calorieresult;//テキストの表示
    // Start is called before the first frame update
    void Start()
    {
        //マカロン
        isDisplayedM = false;
        objectToShowM.SetActive(false);
        //パンケーキ
        isDisplayedPancake = false;
        objectToShowPancake.SetActive(false);
        //パフェ
        isDisplayedParfait = false;
        objectToShowParfait.SetActive(false);
        //ケーキ
        isDisplayedC = false;
        objectToShowC.SetActive(false);
        //
        isDisplayed = false;
        objectToShow.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        calorieresult.text = "カロリーは" + CalorieTEXT.CalorieTEXTInitival + "Kcal残ったよ。".ToString();//カロリーのテキスト文字をカロリーの初期値におく
       
        
    }


}
