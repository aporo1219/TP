using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float TimerS = 0.0f;//��莞�Ԓ�����ƈړ����Ȃ�����ϐ�
    private Transform movement;//�ړ��̕ϐ�
   

    // Update is called once per frame
    void Update()
    {
        //�ړ����Ȃ����邽�߂̏���
        TimerS += Time.deltaTime;
        if (TimerS != 30.0)
        {
            //�Q�[���I�u�W�F�N�g�̌��݂̍��W�ʒu����
            movement = gameObject.transform;

            //1�b�Ԃɂ�����ړ����邩�̏���
            transform.position += new Vector3(-3, 0,0) * Time.deltaTime;
          
        }

    }
    
}
