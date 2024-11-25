using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AppearenceOne : MonoBehaviour
{
    //����
    public GameObject objectToShowany;
    public float displayDelayany = 30.0f; // �\���܂ł̑ҋ@���ԁi�b�j
    private float timerany;
    private bool isDisplayedany;
   
    private void Start()
    {
        // �������i�o���j
        //����
        timerany = 0.0f;
        isDisplayedany = false;
        objectToShowany.SetActive(false); // �Q�[���J�n���ɃI�u�W�F�N�g���\���ɂ���
    }

    private void Update()
    {
        //�o���̏���
        //����
        if (!isDisplayedany)
        {
            timerany += Time.deltaTime; // �o�ߎ��Ԃ��J�E���g

            if (timerany>= displayDelayany)
            {
                // ��莞�Ԍo�߂�����I�u�W�F�N�g��\��
                objectToShowany.SetActive(true);
                isDisplayedany = true;

            }
        }
        
    }
}

