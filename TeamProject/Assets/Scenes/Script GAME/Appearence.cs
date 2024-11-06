using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Appearence : MonoBehaviour
{
    //���h�q
    public GameObject objectToShowchili;
    public float displayDelaychili = 30.0f; // �\���܂ł̑ҋ@���ԁi�b�j
    private float timerchili;
    private bool isDisplayedchili;
   //�`���R���[�g
    public GameObject objectToShowchoco;
    public float displayDelaychoco = 30.0f; // �\���܂ł̑ҋ@���ԁi�b�j
    private float timerchoco; 
    private bool isDisplayedchoco;
    //�N�b�L�[
    public GameObject objectToShowcookie;
    public float displayDelaycookie = 30.0f; // �\���܂ł̑ҋ@���ԁi�b�j
    private float timercookie;
    private bool isDisplayedcookie;
    //�_���x��
    public GameObject objectToShowdombbell;
    public float displayDelaydombbell = 30.0f; // �\���܂ł̑ҋ@���ԁi�b�j
    private float timerdombbell;
    private bool isDisplayedombbell;
    //���Ƃ���
    public GameObject objectToShowpitfall;
    public float displayDelaypitfall = 30.0f; // �\���܂ł̑ҋ@���ԁi�b�j
    private float timerpitfall;
    private bool isDisplayedpitfall;
    //�v����
    public GameObject objectToShowpudding;
    public float displayDelaypudding = 30.0f; // �\���܂ł̑ҋ@���ԁi�b�j
    private float timerpudding;
    private bool isDisplayedpudding;
    private void Start()
    {
        // �������i�o���j
        //���h�q
        timerchili = 0.0f;
        isDisplayedchili = false;
        objectToShowchili.SetActive(false); // �Q�[���J�n���ɃI�u�W�F�N�g���\���ɂ���
        //�`���R���[�g
        timerchoco = 0.0f;
        isDisplayedchoco = false;
        objectToShowchoco.SetActive(false); // �Q�[���J�n���ɃI�u�W�F�N�g���\��
        //�N�b�L�[                                
        timercookie = 0.0f;
        isDisplayedcookie = false;
        objectToShowcookie.SetActive(false); // �Q�[���J�n���ɃI�u�W�F�N�g���\���ɂ���
        // �_���x��                                                           
        timerdombbell = 0.0f;
        isDisplayedombbell = false;
        objectToShowdombbell.SetActive(false); // �Q�[���J�n���ɃI�u�W�F�N�g���\���ɂ���
        //���Ƃ���                                                                                                 
        timerpitfall = 0.0f;
        isDisplayedpitfall = false;
        objectToShowpitfall.SetActive(false); // �Q�[���J�n���ɃI�u�W�F�N�g���\���ɂ���
        //�v����                                                                                               
        timerpudding = 0.0f;
        isDisplayedpudding = false;
        objectToShowpudding.SetActive(false); // �Q�[���J�n���ɃI�u�W�F�N�g���\���ɂ���
    }

    private void Update()
    {
        //�o���̏���
        //���h�q
        if (!isDisplayedchili)
        {
            timerchili += Time.deltaTime; // �o�ߎ��Ԃ��J�E���g

            if (timerchili >= displayDelaychili)
            {
                // ��莞�Ԍo�߂�����I�u�W�F�N�g��\��
                objectToShowchili.SetActive(true);
                isDisplayedchili = true;

            }
        }
        //�`���R
        if (!isDisplayedchoco)
        {
            timerchoco += Time.deltaTime; // �o�ߎ��Ԃ��J�E���g

            if (timerchoco >= displayDelaychoco)
            {
                // ��莞�Ԍo�߂�����I�u�W�F�N�g��\��
                objectToShowchoco.SetActive(true);
                isDisplayedchoco = true;

            }
        }
        //�N�b�L�[
        if (!isDisplayedcookie)
        {
            timercookie += Time.deltaTime; // �o�ߎ��Ԃ��J�E���g

            if (timercookie >= displayDelaycookie)
            {
                // ��莞�Ԍo�߂�����I�u�W�F�N�g��\��
                objectToShowcookie.SetActive(true);
                isDisplayedcookie = true;

            }
        }
        //�_���x��
        if (!isDisplayedombbell)
        {
            timerdombbell += Time.deltaTime; // �o�ߎ��Ԃ��J�E���g

            if (timerdombbell >= displayDelaydombbell)
            {
                // ��莞�Ԍo�߂�����I�u�W�F�N�g��\��
                objectToShowdombbell.SetActive(true);
                isDisplayedombbell = true;

            }
        }
        //���Ƃ���
        if (!isDisplayedpitfall)
        {
            timerpitfall += Time.deltaTime; // �o�ߎ��Ԃ��J�E���g

            if (timerpitfall >= displayDelaypitfall)
            {
                // ��莞�Ԍo�߂�����I�u�W�F�N�g��\��
                objectToShowpitfall.SetActive(true);
                isDisplayedpitfall = true;

            }
        }
        //�v����
        if (!isDisplayedpudding)
        {
            timerpudding += Time.deltaTime; // �o�ߎ��Ԃ��J�E���g

            if (timerpudding >= displayDelaypudding)
            {
                // ��莞�Ԍo�߂�����I�u�W�F�N�g��\��
                objectToShowpudding.SetActive(true);
                isDisplayedpudding = true;

            }
        }
    }
}

