using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CalorieTEXT : MonoBehaviour
{
    public static float CalorieTEXTInitival;//�J�����[�����̕ϐ�
    public Text CalorieText;//�J�����[�̕����̕ϐ�
    private float Ctime;//�o�ߎ���
    public static int StageInfor;//�X�e�[�W���̎擾
    public Text RD;//�c�苗���̃e�L�X�g
    public float distance;//�c�苗���̌v�Z�p�̕ϐ�

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;//A�{�^���������܂Œ�~
        CalorieTEXTInitival = 100;//�J�����[�e�L�X�g�̏�����
        StageInfor = 0;//�N���A�����X�e�[�W�ɂ���ă��U���g�̃X�C�[�c�̊G��ς���
        distance = 37;//�����̏�����
    }



    // Update is called once per frame
    void Update()
    { 
        //A�{�^������������Q�[���X�^�[�g
        if(Input.GetKeyDown(KeyCode.A))
        {
            Time.timeScale = 1;
        }
        CalorieText.text = "�J�����[:" + CalorieTEXTInitival + "Kcal".ToString();//�J�����[�̃e�L�X�g�������J�����[�̏����l�ɂ���
        Ctime += Time.deltaTime;//�J�����[�����̐ݒ�

        distance -= Time.deltaTime;//�c�苗���̌v�Z
        RD.text = "���X�܂ł̋�����" + distance + "���[�g���ł��B".ToString();//�c�苗���̃e�L�X�g
        //���Ԍo��(�X�e�[�W�P�j
        if(SceneManager.GetActiveScene().name == "STAGE1")
        {
         �@if (Ctime >= 1.0f)
          {
            CalorieTEXTInitival -= 2;
            Ctime = 0;
           
            StageInfor = 0;
          }
        }
        //���Ԍo��(�X�e�[�W2�j
        if(SceneManager.GetActiveScene().name == "STAGE2")
        {
            if (Ctime >= 1.0f)
            {
                CalorieTEXTInitival -= 5;
                Ctime = 0;

                StageInfor = 1;
            }
        }
        //���Ԍo��(�X�e�[�W3�j
        if (SceneManager.GetActiveScene().name == "STAGE3")
        {
            if (Ctime >= 1.0f)
            {
                CalorieTEXTInitival -= 2;
                Ctime = 0;

                StageInfor = 2;
            }
        }
        //���Ԍo��(�X�e�[�W4�j
        if (SceneManager.GetActiveScene().name == "STAGE4")
        {
            if (Ctime >= 1.0f)
            {
                CalorieTEXTInitival -= 2;
                Ctime = 0;

                StageInfor = 3;
            }
        }
        //���Ԍo��(�X�e�[�W5�j
        if (SceneManager.GetActiveScene().name == "STAGE5")
        {
            if (Ctime >= 1.0f)
            {
                CalorieTEXTInitival -= 5;
                Ctime = 0;

                StageInfor = 4;
            }
        }


        
        //�����100
        if (CalorieTEXTInitival >= 100.0f)
        {
            CalorieTEXTInitival = 100.0f;
        }
        //�Ȃ��Ȃ�����Q�[���I�[�o�[�V�[���̐؂�ւ�
        if (CalorieTEXTInitival <= 0.0f)
        {
            GAMEOVER();
        }

    }
    
    //�I�u�W�F�N�g�ɓ����������̏���
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "pitfall")
        {
            CalorieTEXTInitival -= 20;

        }

        if (collision.gameObject.tag == "chili pepper")
        {
            CalorieTEXTInitival -= 10;

        }
        if (collision.gameObject.tag == "chocolate")
        {
            CalorieTEXTInitival += 20;

        }
        if (collision.gameObject.tag == "cookie")
        {
            CalorieTEXTInitival += 10;

        }
        if (collision.gameObject.tag == "dumbbell")
        {
            CalorieTEXTInitival -= 30;

        }

        if (collision.gameObject.tag == "pudding")
        {
            CalorieTEXTInitival += 30;

        }

        if (collision.gameObject.tag == "Choco night")
        {
            CalorieTEXTInitival += 10;
        }

        if (collision.gameObject.tag == "Pud night")
        {
            CalorieTEXTInitival += 15;
        }

        if (collision.gameObject.tag == "Cook night")
        {
            CalorieTEXTInitival += 5;
        }
    }

   //�Q�[���I�[�o�[�֐�
    private void GAMEOVER()
    {
        SceneManager.LoadScene("GameOver1");

    }


}
