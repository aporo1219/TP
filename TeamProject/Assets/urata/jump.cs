using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    //キャラクターの状態を入れる箱を用意
    public Rigidbody2D chara;
    //キャラクターのジャンプ力の設定
    public float jumpForce = 10f;
    //地面にいるかどうかの判定設定
    private bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        //キャラクターの状態を取得
        chara = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //スペースキーを押されたかどうかを判定
        if (Input.GetButtonDown("Jump"))
        {
            //キャラクターにジャンプさせる
            chara.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            //ジャンプしたら、地面から離れたと判定
            isGrounded = false;
        }
    }

    // 地面に触れているかの判定
    void OnCollisionEnter2D(Collision2D other)
    {
        //接触したオブジェクトの名前が「Asufaruto」だったら作動する
        if (other.gameObject.CompareTag("Asufaruto"))
        {
            //地面と接触していると判定
            isGrounded = true;
        }
    }
}
