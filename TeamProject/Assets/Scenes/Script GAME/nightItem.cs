using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class nightItem : MonoBehaviour
{
    public Slider calobar;
    public Text CalorieText;//�J�����[�̕����̕ϐ�
    private float Ctime;

    // Start is called before the first frame update
    void Start()
    {
        CalorieTEXT.CalorieTEXTInitival = 100;
    }

    // Update is called once per frame
    void Update()
    {
        Ctime += Time.deltaTime;//�J�����[�����̐ݒ�
        //���Ԍo��(�X�e�[�W3�j
        if (SceneManager.GetActiveScene().name == "STAGE3")
        {
            if (Ctime >= 1.0f)
            {
                CalorieTEXT.CalorieTEXTInitival -= 2;
                Ctime = 0;
                calobar.value -= 5;
                Ctime = 0;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "chili pepper")
        {
            calobar.value -= 10;
            CalorieTEXT.CalorieTEXTInitival -= 10;
        }

        if (other.gameObject.tag == "chocolate")
        {
            calobar.value += 10;
            CalorieTEXT.CalorieTEXTInitival += 10;
        }

        if (other.gameObject.tag == "cookie")
        {
            calobar.value += 5;
            CalorieTEXT.CalorieTEXTInitival += 5;
        }

        if (other.gameObject.tag == "dumbbell")
        {
            calobar.value -= 30;
            CalorieTEXT.CalorieTEXTInitival -= 30;
        }

        if (other.gameObject.tag == "pudding")
        {
            calobar.value += 15;
            CalorieTEXT.CalorieTEXTInitival += 15;
        }

        if (other.gameObject.tag == "pitfall")
        {
            calobar.value -= 20;
            CalorieTEXT.CalorieTEXTInitival -= 20;
        }
    }
}