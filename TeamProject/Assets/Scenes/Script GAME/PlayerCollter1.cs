using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollter1 : MonoBehaviour
{
    
    //���Ⴊ��
    private Animator anim = null;

    void Start()
    {
        //���Ⴊ�ރA�j���[�V�����̏�����
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        //�L�[�̑��
        //float horizontalKey = Input.GetKey(KeyCode.S);
        //�����L�[���������炵�Ⴊ��
        if (Input.GetKey(KeyCode.S))
        {
            anim.SetBool("crouch", true);
        }
        else
        {
            anim.SetBool("crouch", false);
        }
    }
}
