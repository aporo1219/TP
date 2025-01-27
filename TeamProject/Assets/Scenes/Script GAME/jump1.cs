using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump1 : MonoBehaviour
{
    public float jumpPower;//�W�����v�͂̕ϐ�
    private Rigidbody2D rb;
    private bool isJumping = false;//�n�ʂɂ��Ă��邩�̔���̕ϐ�
    

    void Start()
    {
        //Rigidbody2D�̎擾
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //�n�ʂɂ��Ă���Ƃ����A�X�y�[�X���������Ƃ��ɃW�����v
        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            rb.velocity = Vector3.up * jumpPower;
            isJumping = true;//��i�W�����v�ɂł��Ȃ��悤�ɂ��鏈��

            //SE�Đ�
            SoundManager.soundManager.SEPlay(SEType.jump);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //�n�ʂɓ���������W�����v�ł���悤�ɂ���
        if (collision.gameObject.CompareTag("Asufaruto"))
        {
            isJumping = false;
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag�@=="empty ca")
        {
            //�ʂɓ���������W�����v�͂��ቺ���鏈��
            jumpPower = 6;
            Invoke(nameof(Timer), 4.0f);
        }
    }
    //���Ԍo�߂ɂ��W�����v�͂��߂鏈���p�̊֐�
    public void Timer()
    {
        jumpPower = 8;
    }
}
