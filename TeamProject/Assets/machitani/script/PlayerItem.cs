using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerItem : MonoBehaviour
{
    public Slider calobar;

    void OnTriggerEnter2D(Collider2D collision)
    {
        //��̃`���R�ɓ���������
        if (collision.gameObject.tag == "Choco night")
        {
            //�J�����[�Q�[�W��10���₷
            calobar.value += 10;
        }
        //��̃v�����ɓ���������
        if (collision.gameObject.tag == "Pud night")
        {
            //�J�����[�Q�[�W��15���₷
            calobar.value += 15;
        }
        //��̃N�b�L�[�ɓ���������
        if (collision.gameObject.tag == "Cook night")
        {
            //�J�����[�Q�[�W���T���₷
            calobar.value += 5;
        }
        //���Ƃ����ɓ���������
        if (collision.gameObject.tag == "pitfall")
        {
            //�J�����[�Q�[�W��20���炷
            calobar.value -= 20;
        }
        //���h�q�ɓ���������
        if (collision.gameObject.tag == "chili pepper")
        {
            //�J�����[�Q�[�W��10���炷
            calobar.value -= 10;
        }
        //�`���R���[�g�ɓ���������
        if (collision.gameObject.tag == "chocolate")
        {
            //�J�����[�Q�[�W��20���₷
            calobar.value += 20;
        }
        //�N�b�L�[�ɓ���������
        if (collision.gameObject.tag == "cookie")
        {
            //�J�����[�Q�[�W��10���₷
            calobar.value += 10;
        }
        //�_���x���ɓ���������
        if (collision.gameObject.tag == "dumbbell")
        {
            //�J�����[�Q�[�W��30���炷
            calobar.value -= 30;
        }
        //�v�����ɓ���������
        if (collision.gameObject.tag == "pudding")
        {
            //�J�����[�Q�[�W��30���₷
            calobar.value += 30;
        }
    }
}