using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RESULT1 : MonoBehaviour
{
    public Text calorieresult;//�e�L�X�g�̕\��
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        calorieresult.text = "�J�����[��" + CalorieTEXT.CalorieTEXTInitival + "Kcal�c������B".ToString();//�J�����[�̃e�L�X�g�������J�����[�̏����l�ɂ���
    }


}
