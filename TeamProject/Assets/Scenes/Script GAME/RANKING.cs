using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class RANKING : MonoBehaviour
{
    public Text highcalorieTEXT;//�n�C�J�����[����\������TEXT
    public Text highcalorieTEXT2;//�n�C�J�����[����\������TEXT
    public Text highcalorieTEXT3;//�n�C�J�����[����\������TEXT
    public Text highcalorieTEXT4;//�n�C�J�����[����\������TEXT
    public Text highcalorieTEXT5;//�n�C�J�����[����\������TEXT
    public GameObject HCT1;//�n�C�J�����[����\������TEXT��\���A��\��
    public GameObject HCT2;//�n�C�J�����[����\������TEXT��\���A��\��
    public GameObject HCT3;//�n�C�J�����[����\������TEXT��\���A��\��
    public GameObject HCT4;//�n�C�J�����[����\������TEXT��\���A��\��
    public GameObject HCT5;//�n�C�J�����[����\������TEXT��\���A��\��
    private int HC1;//�n�C�J�����[���̕ϐ�
    private int HC2;//�n�C�J�����[���̕ϐ�
    private int HC3;//�n�C�J�����[���̕ϐ�
    private int HC4;//�n�C�J�����[���̕ϐ�
    private int HC5;//�n�C�J�����[���̕ϐ�


    public void Start()
    {
        HC1 = PlayerPrefs.GetInt("HIGHCALORIE1", HC1);
        HC2 = PlayerPrefs.GetInt("HIGHCALORIE2", HC2);
        HC3 = PlayerPrefs.GetInt("HIGHCALORIE3", HC3);
        HC4 = PlayerPrefs.GetInt("HIGHCALORIE4", HC4);
        HC5 = PlayerPrefs.GetInt("HIGHCALORIE5", HC5);

        HCT1.SetActive(false);
        HCT2.SetActive(false);
        HCT3.SetActive(false);
        HCT4.SetActive(false);
        HCT5.SetActive(false);

    }

    
    public void Update()
    {
        //�N���A�����X�e�[�W�ɂ���Ẵx�X�g�J�����[�ʂ̕\��
        if (CalorieTEXT.StageInfor == 0)
        {
            HCT1.SetActive(true);
            highcalorieTEXT.text = "�J�����[�̍ō��c�ʂ�" + HC1 + "�ł��B".ToString();
            PlayerPrefs.SetInt("HIGHCALORIE1", HC1);
            PlayerPrefs.Save();//�X�R�A�̕ۑ��֐�
            if (Input.GetKeyDown(KeyCode.Space))//�X�y�[�X�������ꂽ��J�����[�ʂ̃��Z�b�g
            {
                PlayerPrefs.DeleteKey("HIGHCALORIE1");
            }
        }
        if (CalorieTEXT.StageInfor == 1)
        {
            HCT2.SetActive(true);
            highcalorieTEXT2.text = "�J�����[�̍ō��c�ʂ�" + HC2 + "�ł��B".ToString();
            PlayerPrefs.SetInt("HIGHCALORIE12", HC2);
            PlayerPrefs.Save();//�X�R�A�̕ۑ��֐�
            if (Input.GetKeyDown(KeyCode.Space))
            {
               
            }
        }
        if (CalorieTEXT.StageInfor == 2)
        {
            HCT3.SetActive(true);
            highcalorieTEXT3.text = "�J�����[�̍ō��c�ʂ�" + HC3 + "�ł��B".ToString();
            PlayerPrefs.SetInt("HIGHCALORIE3", HC3);
            PlayerPrefs.Save();//�X�R�A�̕ۑ��֐�
            if (Input.GetKeyDown(KeyCode.Space))
            {
                
            }
        }
        if (CalorieTEXT.StageInfor == 3)
        {
            HCT4.SetActive(true);
            highcalorieTEXT4.text = "�J�����[�̍ō��c�ʂ�" + HC4 + "�ł��B".ToString();
            PlayerPrefs.SetInt("HIGHCALORIE4", HC4);
            PlayerPrefs.Save();//�X�R�A�̕ۑ��֐�
            if (Input.GetKeyDown(KeyCode.Space))
            {
                
            }
        }
        if (CalorieTEXT.StageInfor == 4)
        {
            HCT5.SetActive(true);
            highcalorieTEXT5.text = "�J�����[�̍ō��c�ʂ�" + HC5 + "�ł��B".ToString();
            PlayerPrefs.SetInt("HIGHCALORIE5", HC5);
            PlayerPrefs.Save();//�X�R�A�̕ۑ��֐�
            if (Input.GetKeyDown(KeyCode.Space))
            {

            }
        }
        //�n�C�J�����[��茻�݂̃J�����[�ʂ��������Ƃ�
        if (CalorieTEXT.CalorieTEXTInitival > HC1)
        {
            HC1 = (int)CalorieTEXT.CalorieTEXTInitival;//�X�V����
            highcalorieTEXT.text = "�J�����[�̍ō��c�ʂ�" + HC1 + "�ł��B".ToString();//�n�C�J�����[�ʂ̕\��


            if (Input.GetKeyDown(KeyCode.Space))
            {
               
            }

        }
        //�n�C�J�����[��茻�݂̃J�����[�ʂ��������Ƃ�
        if (CalorieTEXT.CalorieTEXTInitival > HC2)
        {
            HC2 = (int)CalorieTEXT.CalorieTEXTInitival;//�X�V����
            highcalorieTEXT.text = "�J�����[�̍ō��c�ʂ�" + HC2 + "�ł��B".ToString(); //�n�C�J�����[�ʂ̕\��

            if (Input.GetKeyDown(KeyCode.Space))
            {
                PlayerPrefs.DeleteKey("HIGHCALORIE1");
            }
        }
        //�n�C�J�����[��茻�݂̃J�����[�ʂ��������Ƃ�
        if (CalorieTEXT.CalorieTEXTInitival > HC3)
        {
            HC3 = (int)CalorieTEXT.CalorieTEXTInitival;//�X�V����
            highcalorieTEXT.text = "�J�����[�̍ō��c�ʂ�" + HC3 + "�ł��B".ToString();//�n�C�J�����[�ʂ̕\��

            if (Input.GetKeyDown(KeyCode.Space))
            {
                
            }
        }
        //�n�C�J�����[��茻�݂̃J�����[�ʂ��������Ƃ�
        if (CalorieTEXT.CalorieTEXTInitival > HC4)
        {
            HC4 = (int)CalorieTEXT.CalorieTEXTInitival;//�X�V����
            highcalorieTEXT.text = "�J�����[�̍ō��c�ʂ�" + HC4 + "�ł��B".ToString();//�n�C�J�����[�ʂ̕\��

            if (Input.GetKeyDown(KeyCode.Space))
            {
                
            }
        }
        //�n�C�J�����[��茻�݂̃J�����[�ʂ��������Ƃ�
        if (CalorieTEXT.CalorieTEXTInitival > HC5)
        {
            HC5 = (int)CalorieTEXT.CalorieTEXTInitival;//�X�V����
            highcalorieTEXT.text = "�J�����[�̍ō��c�ʂ�" + HC5 + "�ł��B".ToString();//�n�C�J�����[�ʂ̕\��

            if (Input.GetKeyDown(KeyCode.Space))
            {
                
            }
        }
        

    }




}

