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
        float horizontalKey = Input.GetAxis("Horizontal");
        //�����L�[���������炵�Ⴊ��
        if (horizontalKey < 0)
        {
            anim.SetBool("crouch", true);
        }
        else
        {
            anim.SetBool("crouch", false);
        }
    }
}
