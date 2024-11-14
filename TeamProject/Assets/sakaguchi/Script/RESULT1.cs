using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RESULT1 : MonoBehaviour
{
    public Text calorieresult;//テキストの表示
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        calorieresult.text = "カロリーは" + CalorieTEXT.CalorieTEXTInitival + "Kcal残ったよ。".ToString();//カロリーのテキスト文字をカロリーの初期値におく
    }


}
