using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump1 : MonoBehaviour
{
    public float jumpPower;//ジャンプ力の変数
    private Rigidbody2D rb;
    private bool isJumping = false;//地面についているかの判定の変数
    

    void Start()
    {
        //Rigidbody2Dの取得
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //地面についているときかつ、スペースを押したときにジャンプ
        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            rb.velocity = Vector3.up * jumpPower;
            isJumping = true;//二段ジャンプにできないようにする処理

            //SE再生
            SoundManager.soundManager.SEPlay(SEType.jump);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //地面に当たったらジャンプできるようにする
        if (collision.gameObject.CompareTag("Asufaruto"))
        {
            isJumping = false;
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag　=="empty ca")
        {
            //缶に当たったらジャンプ力が低下する処理
            jumpPower = 6;
            Invoke(nameof(Timer), 4.0f);
        }
    }
    //時間経過によるジャンプ力が戻る処理用の関数
    public void Timer()
    {
        jumpPower = 8;
    }
}
