using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Result : MonoBehaviour
{
    //�N���A��ʂ̃X�C�[�c�I�u�W�F�N�g�̕ϐ�
    [SerializeField] public GameObject Macaron;
    [SerializeField] public GameObject Pancake;
    [SerializeField] public GameObject Parfait;
    [SerializeField] public GameObject Cake;
    [SerializeField] public GameObject Dounatu;

    //�e�L�X�g�̕ϐ�
    public Text resultcalo;

    
    


    void Start()
    {
        //�����̏�����
        Macaron.SetActive(false);
        Pancake.SetActive(false);
        Parfait.SetActive(false);
        Cake.SetActive(false);
        Dounatu.SetActive(false);
    }

     void Update()
    {
       
        //�����̕\��
        resultcalo.text = "�J�����[�̎c�ʂ�" + CalorieTEXT.CalorieTEXTInitival + "kcal�ł��B";
�@�@�@�@ 
        if(CalorieTEXT.StageInfor == 0)//�X�e�[�W1�̃X�C�[�c�̕\��
        {
            Dounatu.SetActive(true);
        }
        if (CalorieTEXT.StageInfor == 1)//�X�e�[�W2�̃X�C�[�c�̕\��
        {
            Macaron.SetActive(true);
        }
        if (CalorieTEXT.StageInfor == 2)//�X�e�[�W3�̃X�C�[�c�̕\��
        {
            Parfait.SetActive(true);
        }
        if (CalorieTEXT.StageInfor == 3)//�X�e�[�W4�̃X�C�[�c�̕\��
        {
            Pancake.SetActive(true);
        }
        if (CalorieTEXT.StageInfor == 4)//�X�e�[�W5�̃X�C�[�c�̕\��
        {
            Cake.SetActive(true);
        }
   �@}

}

