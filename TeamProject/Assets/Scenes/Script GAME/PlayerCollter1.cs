using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollter1 : MonoBehaviour
{
    
    //しゃがむ
    private Animator anim = null;

    void Start()
    {
        //しゃがむアニメーションの初期化
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        //キーの代入
        float horizontalKey = Input.GetAxis("Horizontal");
        //下矢印キーを押したらしゃがむ
        if (horizontalKey < 0)
        {
            anim.SetBool("crouch", true);
        }
        else
        {
            anim.SetBool("crouch", false);
        }
    }
}
