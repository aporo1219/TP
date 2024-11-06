using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GoalS1 : MonoBehaviour
{
    public GameObject objectToShowGS;
    public float displayDelayGS = 2.0f; // �\���܂ł̑ҋ@���ԁi�b�j

    private float timerGS;
    private bool isDisplayedGS;



    private void Start()
    {
        // �������i�o���j
        timerGS = 0.0f;
        isDisplayedGS = false;
        objectToShowGS.SetActive(false); // �Q�[���J�n���ɃI�u�W�F�N�g���\���ɂ���



    }

    private void Update()
    {
        //�o���̏���
        if (!isDisplayedGS)
        {
            timerGS += Time.deltaTime; // �o�ߎ��Ԃ��J�E���g

            if (timerGS >= displayDelayGS)
            {
                // ��莞�Ԍo�߂�����I�u�W�F�N�g��\��
                objectToShowGS.SetActive(true);
                isDisplayedGS = true;

            }
        }
    }
}

