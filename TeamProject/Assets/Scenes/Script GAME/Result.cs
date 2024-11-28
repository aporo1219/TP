using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Result : MonoBehaviour
{
    [SerializeField] public GameObject M;
    [SerializeField] public GameObject Pan;
    [SerializeField] public GameObject Par;
    [SerializeField] public GameObject C;
    [SerializeField] public GameObject D;

    public Text resultcalo;


    void Start()
    {
        M.SetActive(false);
        Pan.SetActive(false);
        Par.SetActive(false);
        C.SetActive(false);
        D.SetActive(false);
    }

     void Update()
    {
        resultcalo.text = "�J�����[�̎c�ʂ�" + CalorieTEXT.CalorieTEXTInitival + "kcal�ł��B";//�����̕\��

        if(CalorieTEXT.StageInfor == 0)//�X�e�[�W1�̃X�C�[�c�̕\��
        {
            D.SetActive(true);
        }
        if (CalorieTEXT.StageInfor == 1)//�X�e�[�W2�̃X�C�[�c�̕\��
        {
            M.SetActive(true);
        }
        if (CalorieTEXT.StageInfor == 2)//�X�e�[�W3�̃X�C�[�c�̕\��
        {
            Par.SetActive(true);
        }
        if (CalorieTEXT.StageInfor == 3)//�X�e�[�W4�̃X�C�[�c�̕\��
        {
            Pan.SetActive(true);
        }
        if (CalorieTEXT.StageInfor == 4)//�X�e�[�W5�̃X�C�[�c�̕\��
        {
            C.SetActive(true);
        }
    }
}