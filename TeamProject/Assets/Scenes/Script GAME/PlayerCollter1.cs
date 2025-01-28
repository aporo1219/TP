using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollter1 : MonoBehaviour
{
    
    //しゃがむ
    private Animator anim = null;
    public BoxCollider2D Hit_Judgment;
   

    void Start()
    {
        //しゃがむアニメーションの初期化
        anim = GetComponent<Animator>();
        Hit_Judgment = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        //キーの代入
        //float horizontalKey = Input.GetKey(KeyCode.S);
        //Sキーを押したらしゃがむ
        if (Input.GetKey(KeyCode.S))
        {
            anim.SetBool("crouch", true);
        }
        //それ以外はしゃがみを解除する
        else
        {
            anim.SetBool("crouch", false);
        }


        if(CalorieTEXT.Fnish == 1)
        {
            Hit_Judgment.enabled = false;
        }
    }

   
}
