using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CalorieTEXT : MonoBehaviour
{
    public static float CalorieTEXTInitival;//�J�����[�����̒l�̕ϐ�
    public Text CalorieText;//�J�����[�̕����̕ϐ�
    private float Calorietime;//�o�ߎ���
    public static int StageInfor;//�X�e�[�W���̎擾
    public Text RemainingDistance;//�c�苗���̃e�L�X�g
    public float Distance;//�c�苗���̕ϐ�
    public float Way;//�c�苗���v�Z�p�̕ϐ�
    private float StayTime;
    public GameObject NotEnergy;
    public GameObject NotEnergyBack;



    // Start is called before the first frame update
    void Start()
    {
        Distance = 37.0f;
        Time.timeScale = 0;//A�{�^���������܂Œ�~
        CalorieTEXTInitival = 100;//�J�����[�e�L�X�g�̏�����
        StageInfor = 0;//�N���A�����X�e�[�W�ɂ���ă��U���g�̃X�C�[�c�̊G��ς���
        NotEnergy.SetActive(false);
        NotEnergyBack.SetActive(false);
    }



    // Update is called once per frame
    void Update()
    {
        //A�{�^������������Q�[���X�^�[�g
        if (Input.GetKeyDown(KeyCode.A))
        {
            IsPause();
        }

        //�J�����[�e�L�X�g�֘A�̊֐�
        CalorieCharacter();

        //�����֘A�̊֐�
        RemainingDistanceFunction();
        

    }
    public void IsPause()
    {
        Time.timeScale = 1;
    }
    
    //�J�����[�e�L�X�g�֘A�̊֐�
    //����
    public void CalorieCharacter()
    {
        //�J�����[�̃e�L�X�g�����̕\��
        CalorieText.text = "�J�����[:" + CalorieTEXTInitival + "Kcal".ToString();
        Calorietime += Time.deltaTime;//�J�����[�����̐ݒ�
        
        

        //���Ԍo��(�X�e�[�W�P�j
        if (SceneManager.GetActiveScene().name == "STAGE1")
        {
            if (Calorietime >= 1.0f)
            {
                CalorieTEXTInitival -= 2;
                Calorietime = 0;

                StageInfor = 0;
            }
        }
        //���Ԍo��(�X�e�[�W2�j
        if (SceneManager.GetActiveScene().name == "STAGE2")
        {
            if (Calorietime >= 1.0f)
            {
                CalorieTEXTInitival -= 5;
                Calorietime = 0;

                StageInfor = 1;
            }
        }
        //���Ԍo��(�X�e�[�W3�j
        if (SceneManager.GetActiveScene().name == "STAGE3")
        {
            if (Calorietime >= 1.0f)
            {
                CalorieTEXTInitival -= 2;
                Calorietime = 0;

                StageInfor = 2;
            }
        }
        //���Ԍo��(�X�e�[�W4�j
        if (SceneManager.GetActiveScene().name == "STAGE4")
        {
            if (Calorietime >= 1.0f)
            {
                CalorieTEXTInitival -= 2;
                Calorietime = 0;

                StageInfor = 3;
            }
        }

        //���Ԍo��(�X�e�[�W5�j
        if (SceneManager.GetActiveScene().name == "STAGE5")
        {
            if (Calorietime >= 1.0f)
            {
                CalorieTEXTInitival -= 5;
                Calorietime = 0;

                StageInfor = 4;
            }
        }
        
        //�����100�ɂ��A100�𒴂���Ɛ��l��100�ɂ���
        if (CalorieTEXTInitival >= 100.0f)
        {
            CalorieTEXTInitival = 100.0f;
        }

        //�J�����[�Q�[�W���O�ɂȂ�ƃQ�[���I�[�o�[�V�[���ɑ���
        if (CalorieTEXTInitival <= 0.0f)
        {
            GameOver();
        }
      
      
    }

    //�����̊֐�
    public void RemainingDistanceFunction()
    {
        Way += Time.deltaTime;//�c�苗�����v�Z�����߂̏���
        RemainingDistance.text = "���X�܂ł̋�����" + Distance + "���[�g���ł��B".ToString();//�c�苗���̃e�L�X�g
        //�c�苗���̌v�Z
        if(Way >= 1.0f)
        {
            Distance -= 1;
            Way = 0;
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

    

   public void GameOver()
   { 
        NotEnergy.SetActive(true);
        NotEnergyBack.SetActive(true);
        StayTime += Time.deltaTime;
        if(StayTime >= 3)
        {
          SceneManager.LoadScene("GAMEOVER1");
           StayTime = 0;
        }
    }
}
