using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    //2�i�W�����v�֎~�̃W�����v

    public float jumpPower;//�W�����v��
    private Rigidbody2D rb;//�����@��
    private bool isJumping = false;//�[���W�����v

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();//�����@���̃R���|�[�l���g�𓾂���
    }

    void Update()
    {
        //�X�y�[�X�L�[�������ꂽ��W�����v����
        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            rb.velocity = Vector3.up * jumpPower;//�W�����v���x
            isJumping = true;//�W�����v����
            //SE�Đ�
            SoundManager.soundManager.SEPlay(SEType.jump);
        }
    }

    //�����蔻��
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //�^�OAsufaruto�ɐG�ꂽ�ꍇ�W�����v����������
        if (collision.gameObject.CompareTag("Asufaruto"))
        {
            isJumping = false;//�W�����v����
        }
    }
}