using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CalorieTEXT : MonoBehaviour
{
    public float CalorieTEXTInitival = 100;//�J�����[�����̏�����
    public Text CalorieText;//�J�����[�̕����̕ϐ�
    // Start is called before the first frame update
    void Start()
    {
        
        

    }
    
    

    // Update is called once per frame
    void Update()
    {
        CalorieTEXTInitival -= Time.deltaTime * 2;//�J�����[�����̐ݒ�
        CalorieText.text = "Calorie:" + CalorieTEXTInitival.ToString();//�J�����[�̃e�L�X�g�������J�����[�̏����l�ɂ���
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
        if (other.gameObject.tag == "pitfall")
        {
            CalorieTEXTInitival -= 30;

        }
        if (other.gameObject.tag == "pudding")
        {
            CalorieTEXTInitival += 20;

        }


    }
        public void GAMEOVER()
    {
        SceneManager.LoadScene("GameOver1");
    }
}
