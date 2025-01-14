using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //歩く
     private float STEP = 3.0f;
    //しゃがむ
    private Animator anim = null;

    void Start()
    {
        //アニメーション
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        //下矢印キーを押したらしゃがむ
        if (Input.GetKey(KeyCode.S))
        {
            anim.SetBool("crouch", true);
        }
        else
        {
            anim.SetBool("crouch", false);
        }
        //右向き
        this.transform.position += new Vector3(STEP * Time.deltaTime, 0, 0);
    }
}
