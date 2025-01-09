using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Cleark1: MonoBehaviour
{
    public GameObject ObjectToShowCleark;
    public float DisplayDelay = 2.0f; // �\���܂ł̑ҋ@���ԁi�b�j
    private float TimerCleark;
    private bool IsDisplayedCleark;

    

    private void Start()
    {
        // �������i�o���j
        TimerCleark = 0.0f;
        IsDisplayedCleark = false;
        ObjectToShowCleark.SetActive(false); // �Q�[���J�n���ɃI�u�W�F�N�g���\���ɂ���

       

    }

    private void Update()
    {
        //�o���̏���
        if (!IsDisplayedCleark)
        {
            TimerCleark += Time.deltaTime; // �o�ߎ��Ԃ��J�E���g

            if (TimerCleark >= DisplayDelay)
            {
                // ��莞�Ԍo�߂�����I�u�W�F�N�g��\��
                ObjectToShowCleark.SetActive(true);
                IsDisplayedCleark = true;
               
            }
        }
    }
}

