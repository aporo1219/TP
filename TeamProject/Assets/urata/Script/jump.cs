using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    //2段ジャンプ禁止のジャンプ

    public float jumpPower;//ジャンプ力
    private Rigidbody2D rb;//物理法則
    private bool isJumping = false;//擬似ジャンプ

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();//物理法則のコンポーネントを得たら
    }

    void Update()
    {
        //スペースキーが押されたらジャンプする
        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            rb.velocity = Vector3.up * jumpPower;//ジャンプ速度
            isJumping = true;//ジャンプする
            //SE再生
            SoundManager.soundManager.SEPlay(SEType.jump);
        }
    }

    //当たり判定
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //タグAsufarutoに触れた場合ジャンプが復活する
        if (collision.gameObject.CompareTag("Asufaruto"))
        {
            isJumping = false;//ジャンプ復活
        }
    }
}