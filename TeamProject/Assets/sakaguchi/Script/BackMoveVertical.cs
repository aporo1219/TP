using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackMoveVertical : MonoBehaviour
{
    public float speed = 0;//�X�N���[������X�s�[�h�̕ϐ�
   

    // Update is called once per frame
    void Update()
    {
        MoveVertical();//�w�i�ړ��i�c�j�̊֐�
    }

    void MoveVertical()
    {
        transform.position -= new Vector3(0, Time.deltaTime * speed);//���ɊG�𓮂���

        if(transform.position.y <= -8.6)//�G�����܂ōs�������ɖ߂�
        {
            transform.position = new Vector3(0, 18.1f);
        }
    }
}
