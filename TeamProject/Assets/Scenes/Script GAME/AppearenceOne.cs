using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AppearenceOne : MonoBehaviour
{
    //����
    public GameObject objectToShowThing;//�I�u�W�F�N�g�̕ϐ�
    public float displayDelayThing = 30.0f; // �\���܂ł̑ҋ@���ԁi�b�j
    private float timerThing;//�����v�Z�p�̕ϐ�
    private bool isDisplayedThing;
   
    

   

    private void Start()
    {
        // �������i�o���j
        //����
        timerThing = 0.0f;
        isDisplayedThing = false;
        objectToShowThing.SetActive(false); // �Q�[���J�n���ɃI�u�W�F�N�g���\���ɂ���
        GameObject dumbbell = GameObject.FindWithTag("dumbbell");
      
    }

    private void Update()
    {
        //�o���̏���
        //����
        if (!isDisplayedThing)
        {
             Thing();
        }
    }

    //���̏����̊֐�
    public void Thing()
    {
        timerThing += Time.deltaTime; // �o�ߎ��Ԃ��J�E���g

        if (timerThing >= displayDelayThing)
        {
            // ��莞�Ԍo�߂�����I�u�W�F�N�g��\��
            objectToShowThing.SetActive(true);
            isDisplayedThing = true;
            
        }
    }

   
}

