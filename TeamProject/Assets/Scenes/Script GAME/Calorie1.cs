using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Calorie1 : MonoBehaviour
{
    public Slider calobar;//�J�����[�o�[�̕ϐ�
    public int calo = 100;//�ő�l�̕ϐ�
    private float currentTime = 0f;//�o�ߎ���
  
    
    // Start is called before the first frame update
    void Start()
    {
        //�J�����[�o�[��������
        calobar = GameObject.Find("calobar").GetComponent<Slider>();
        
        //�J�����[�o�[�ɃJ�����[�̍ő�l��������
        calobar.maxValue = calo;

        calobar.value = 100;
       
    }

    // Update is called once per frame
    void Update()
    {
       //���Ԍo�߂̃J�����[�o�[�����̏���
        currentTime += Time.deltaTime;
       
        if (currentTime >=1.0f)
        {
            //2�������Ă���
            calobar.value -= 2;
            currentTime = 0;
        }
       
    }
     
     

    
   
}
