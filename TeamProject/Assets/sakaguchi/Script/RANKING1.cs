using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class RANKING1 : MonoBehaviour
{
    public Text highcalorieTEXT;//�n�C�J�����[����\������TEXT
    private int HC;//�n�C�J�����[���̕ϐ�



    public void Start()
    {
        HC = PlayerPrefs.GetInt("HIGHCALORIE", 0);
        highcalorieTEXT.text = "�J�����[�̍ō��c�ʂ�" + HC + "�ł��B".ToString();
    }

    public void SAVE()
    {
        PlayerPrefs.SetInt("HIGHCALORIE", HC);
    }
    public void Update()
    {
        //�n�C�J�����[��茻�݂̃J�����[�ʂ��������Ƃ�
        if (CalorieTEXT.CalorieTEXTInitival > HC)
        {
            HC = (int)CalorieTEXT.CalorieTEXTInitival;//�X�V����
            highcalorieTEXT.text = "�J�����[�̍ō��c�ʂ�" + HC + "�ł��B".ToString();

            //�n�C�J�����[�ʂ̕\��
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RESET();//�X�y�[�X�������ꂽ��J�����[�ʂ̃��Z�b�g
        }

    }

    public void RESET()
    {
        PlayerPrefs.DeleteAll();
    }




}

