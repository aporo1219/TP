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
    private int HC1;//�n�C�J�����[���̕ϐ�
    private int HC2;//�n�C�J�����[���̕ϐ�
    private int HC3;//�n�C�J�����[���̕ϐ�
    private int HC4;//�n�C�J�����[���̕ϐ�
    private int HC5;//�n�C�J�����[���̕ϐ�


    public void Start()
    {
        HC1 = PlayerPrefs.GetInt("HIGHCALORIE1", 0);
        HC1 = PlayerPrefs.GetInt("HIGHCALORIE2", 0);
        HC1 = PlayerPrefs.GetInt("HIGHCALORIE3", 0);
        HC1 = PlayerPrefs.GetInt("HIGHCALORIE4", 0);
        HC1 = PlayerPrefs.GetInt("HIGHCALORIE5", 0);

        //�N���A�����X�e�[�W�ɂ���Ẵx�X�g�J�����[�ʂ̕\��
        if (CalorieTEXT.StageInfor == 0)
        {
          highcalorieTEXT.text = "�J�����[�̍ō��c�ʂ�" + HC1 + "�ł��B".ToString();
        }
        if (CalorieTEXT.StageInfor == 1)
        {
            highcalorieTEXT2.text = "�J�����[�̍ō��c�ʂ�" + HC2 + "�ł��B".ToString();
        }
        if (CalorieTEXT.StageInfor == 2)
        {
            highcalorieTEXT3.text = "�J�����[�̍ō��c�ʂ�" + HC3 + "�ł��B".ToString();
        }
        if (CalorieTEXT.StageInfor == 3)
        {
            highcalorieTEXT4.text = "�J�����[�̍ō��c�ʂ�" + HC4 + "�ł��B".ToString();
        }
        if (CalorieTEXT.StageInfor == 4)
        {
            highcalorieTEXT5.text = "�J�����[�̍ō��c�ʂ�" + HC5 + "�ł��B".ToString();
        }

    }

    public void SAVE()
    {
        PlayerPrefs.SetInt("HIGHCALORIE1", HC1);
        PlayerPrefs.SetInt("HIGHCALORIE2", HC2);
        PlayerPrefs.SetInt("HIGHCALORIE3", HC3);
        PlayerPrefs.SetInt("HIGHCALORIE4", HC4);
        PlayerPrefs.SetInt("HIGHCALORIE5", HC5);
    }
    public void Update()
    {
        //�n�C�J�����[��茻�݂̃J�����[�ʂ��������Ƃ�
        if (CalorieTEXT.CalorieTEXTInitival > HC1)
        {
            HC1 = (int)CalorieTEXT.CalorieTEXTInitival;//�X�V����
            highcalorieTEXT.text = "�J�����[�̍ō��c�ʂ�" + HC1 + "�ł��B".ToString();//�n�C�J�����[�ʂ̕\��

            if (Input.GetKeyDown(KeyCode.Space))
            {
                RESET1();//�X�y�[�X�������ꂽ��J�����[�ʂ̃��Z�b�g
            }

            
        }
        //�n�C�J�����[��茻�݂̃J�����[�ʂ��������Ƃ�
        if (CalorieTEXT.CalorieTEXTInitival > HC2)
        {
            HC2 = (int)CalorieTEXT.CalorieTEXTInitival;//�X�V����
            highcalorieTEXT.text = "�J�����[�̍ō��c�ʂ�" + HC2 + "�ł��B".ToString(); //�n�C�J�����[�ʂ̕\��

            if (Input.GetKeyDown(KeyCode.Space))
            {
                RESET2();//�X�y�[�X�������ꂽ��J�����[�ʂ̃��Z�b�g
            }
        }
        //�n�C�J�����[��茻�݂̃J�����[�ʂ��������Ƃ�
        if (CalorieTEXT.CalorieTEXTInitival > HC3)
        {
            HC3 = (int)CalorieTEXT.CalorieTEXTInitival;//�X�V����
            highcalorieTEXT.text = "�J�����[�̍ō��c�ʂ�" + HC3 + "�ł��B".ToString();//�n�C�J�����[�ʂ̕\��

            if (Input.GetKeyDown(KeyCode.Space))
            {
                RESET3();//�X�y�[�X�������ꂽ��J�����[�ʂ̃��Z�b�g
            }
        }
        //�n�C�J�����[��茻�݂̃J�����[�ʂ��������Ƃ�
        if (CalorieTEXT.CalorieTEXTInitival > HC4)
        {
            HC4 = (int)CalorieTEXT.CalorieTEXTInitival;//�X�V����
            highcalorieTEXT.text = "�J�����[�̍ō��c�ʂ�" + HC4 + "�ł��B".ToString();//�n�C�J�����[�ʂ̕\��

            if (Input.GetKeyDown(KeyCode.Space))
            {
                RESET4();//�X�y�[�X�������ꂽ��J�����[�ʂ̃��Z�b�g
            }
        }
        //�n�C�J�����[��茻�݂̃J�����[�ʂ��������Ƃ�
        if (CalorieTEXT.CalorieTEXTInitival > HC5)
        {
            HC5 = (int)CalorieTEXT.CalorieTEXTInitival;//�X�V����
            highcalorieTEXT.text = "�J�����[�̍ō��c�ʂ�" + HC5 + "�ł��B".ToString();//�n�C�J�����[�ʂ̕\��

            if (Input.GetKeyDown(KeyCode.Space))
            {
                RESET5();//�X�y�[�X�������ꂽ��J�����[�ʂ̃��Z�b�g
            }
        }
        

    }

    public void RESET1()
    {
        PlayerPrefs.DeleteKey("HIGHCALORIE1");
    }

    public void RESET2()
    {
        PlayerPrefs.DeleteKey("HIGHCALORIE2");
    }

    public void RESET3()
    {
       PlayerPrefs.DeleteKey("HIGHCALORIE3"); 
    }

    public void RESET4()
    {
      PlayerPrefs.DeleteKey("HIGHCALORIE4");
    }
 
    public void RESET5()
    {
      PlayerPrefs.DeleteKey("HIGHCALORIE5");
    }



}

