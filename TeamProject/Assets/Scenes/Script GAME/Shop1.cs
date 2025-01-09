using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Shop1 : MonoBehaviour
{
    public GameObject ObjectToShowShop;
    public float DisplayDelayShop = 30.0f; // �\���܂ł̑ҋ@���ԁi�b�j

    private float TimerShop;
    private bool IsDisplayedShop;



    private void Start()
    {
        // �������i�o���j
        TimerShop = 0.0f;
        IsDisplayedShop = false;
        ObjectToShowShop.SetActive(false); // �Q�[���J�n���ɃI�u�W�F�N�g���\���ɂ���



    }

    private void Update()
    {
        //�o���̏���
        if (!IsDisplayedShop)
        {
            TimerShop += Time.deltaTime; // �o�ߎ��Ԃ��J�E���g

            if (TimerShop >= DisplayDelayShop)
            {
                // ��莞�Ԍo�߂�����I�u�W�F�N�g��\��
                ObjectToShowShop.SetActive(true);
                IsDisplayedShop= true;

            }
        }
    }
}

