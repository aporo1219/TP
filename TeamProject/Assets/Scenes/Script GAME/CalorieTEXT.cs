using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CalorieTEXT : MonoBehaviour
{
    public static float CalorieTEXTInitival;//�J�����[�����̏�����
    public Text CalorieText;//�J�����[�̕����̕ϐ�
    private float Ctime;//�o�ߎ���

    // Start is called before the first frame update
    void Start()
    {
        CalorieTEXTInitival = 100;
    }



    // Update is called once per frame
    void Update()
    {
        Ctime += Time.deltaTime;//�J�����[�����̐ݒ�
        //���Ԍo��
        if (Ctime >= 1.0f)
        {
            CalorieTEXTInitival -= 2;
            Ctime = 0;
        }
        CalorieText.text = "�J�����[:" + CalorieTEXTInitival + "Kcal".ToString();//�J�����[�̃e�L�X�g�������J�����[�̏����l�ɂ���
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
    public void OnCollisionEnter2D(Collision2D other)
    {



        if (other.gameObject.tag == "chili pepper")
        {
            CalorieTEXTInitival -= 10;

        }
        if (other.gameObject.tag == "chocolate")
        {
            CalorieTEXTInitival += 20;

        }
        if (other.gameObject.tag == "cookie")
        {
            CalorieTEXTInitival += 10;

        }
        if (other.gameObject.tag == "dumbbell")
        {
            CalorieTEXTInitival -= 30;

        }

        if (other.gameObject.tag == "pudding")
        {
            CalorieTEXTInitival += 20;

        }


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "pitfall")
        {
            CalorieTEXTInitival -= 30;

        }
    }

    public void GAMEOVER()
    {
        SceneManager.LoadScene("GameOver1");

    }


}
