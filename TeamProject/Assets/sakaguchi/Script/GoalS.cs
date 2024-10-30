using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GoalS : MonoBehaviour
{
    public GameObject objectToShow;
    public float displayDelay = 2.0f; // �\���܂ł̑ҋ@���ԁi�b�j

    private float timer;
    private bool isDisplayed;



    private void Start()
    {
        // �������i�o���j
        timer = 0.0f;
        isDisplayed = false;
        objectToShow.SetActive(false); // �Q�[���J�n���ɃI�u�W�F�N�g���\���ɂ���



    }

    private void Update()
    {
        //�o���̏���
        if (!isDisplayed)
        {
            timer += Time.deltaTime; // �o�ߎ��Ԃ��J�E���g

            if (timer >= displayDelay)
            {
                // ��莞�Ԍo�߂�����I�u�W�F�N�g��\��
                objectToShow.SetActive(true);
                isDisplayed = true;

            }
        }
    }
}
