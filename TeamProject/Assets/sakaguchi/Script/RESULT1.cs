using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RESULT1 : MonoBehaviour
{
    //�X�C�[�c�̕\��(�}�J�����j
    public GameObject objectToShowM;
    private bool isDisplayedM;
    //(�p���P�[�L)
    public GameObject objectToShowPancake;
    private bool isDisplayedPancake;
    //(�p�t�F�j
    public GameObject objectToShowParfait;
    private bool isDisplayedParfait;
    //(�P�[�L)
    public GameObject objectToShowC;
    private bool isDisplayedC;
    //()
    public GameObject objectToShow;
    private bool isDisplayed;
    public Text calorieresult;//�e�L�X�g�̕\��
    // Start is called before the first frame update
    void Start()
    {
        //�}�J����
        isDisplayedM = false;
        objectToShowM.SetActive(false);
        //�p���P�[�L
        isDisplayedPancake = false;
        objectToShowPancake.SetActive(false);
        //�p�t�F
        isDisplayedParfait = false;
        objectToShowParfait.SetActive(false);
        //�P�[�L
        isDisplayedC = false;
        objectToShowC.SetActive(false);
        //
        isDisplayed = false;
        objectToShow.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        calorieresult.text = "�J�����[��" + CalorieTEXT.CalorieTEXTInitival + "Kcal�c������B".ToString();//�J�����[�̃e�L�X�g�������J�����[�̏����l�ɂ���
       
        
    }


}
