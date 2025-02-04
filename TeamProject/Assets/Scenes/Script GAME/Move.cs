using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float TimerS = 0.0f;//一定時間超えると移動しなくする変数
    private Transform movement;//移動の変数
   

    // Update is called once per frame
    void Update()
    {
        //移動しなくするための処理
        TimerS += Time.deltaTime;
        if (TimerS != 30.0)
        {
            //ゲームオブジェクトの現在の座標位置を代入
            movement = gameObject.transform;

            //1秒間にいくら移動するかの処理
            transform.position += new Vector3(-3, 0,0) * Time.deltaTime;
          
        }

    }
    
}
