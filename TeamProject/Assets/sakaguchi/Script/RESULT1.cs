using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RESULT1 : MonoBehaviour
{
    //�X�C�[�c�̕\��(�}�J�����j
    public GameObject objectToShowM;
   
    //(�p���P�[�L)
    public GameObject objectToShowPancake;
    
    //(�p�t�F�j
    public GameObject objectToShowParfait;
    
    //(�P�[�L)
    public GameObject objectToShowC;
   
    //(�v����)
    public GameObject objectToShowPudding;
  

    public Text calorieresult;//�e�L�X�g�̕\��
    // Start is called before the first frame update
    void Start()
    {
        //�}�J����
        
        objectToShowM.SetActive(true);
        //�p���P�[�L
        
        objectToShowPancake.SetActive(false);
        //�p�t�F
        
        objectToShowParfait.SetActive(false);
        //�P�[�L
        
        objectToShowC.SetActive(false);
        //�v����
        
        objectToShowPudding.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        calorieresult.text = "�J�����[��" + CalorieTEXT.CalorieTEXTInitival + "Kcal�c������B".ToString();//�J�����[�̃e�L�X�g�������J�����[�̏����l�ɂ���
        if(SceneManager.GetActiveScene().name == "stage2")
        {
            STAGE2GC();
        }
        if (SceneManager.GetActiveScene().name == "stage3")
        {
            STAGE3GC();
        }
        if (SceneManager.GetActiveScene().name == "stage4")
        {
            STAGE4GC();
        }
        if (SceneManager.GetActiveScene().name == "stage5")
        {
            STAGE5GC();
        }

    }
    void STAGE2GC()//�X�e�[�W�Q���N���A������v�����̕\��
    {
        objectToShowM.SetActive(false);
        objectToShowPudding.SetActive(true);
    }
    void STAGE3GC()//�X�e�[�W3���N���A������p�t�F�̕\��
    {
        objectToShowM.SetActive(false);
        objectToShowParfait.SetActive(true);
    }

    void STAGE4GC()//�X�e�[�W4���N���A������p���P�[�L�̕\��
    {
        objectToShowM.SetActive(false);
        objectToShowPancake.SetActive(true);
    }

    void STAGE5GC()//�X�e�[�W5���N���A������P�[�L�̕\��
    {
        objectToShowM.SetActive(false);
        objectToShowC.SetActive(true);
    }
}
