using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        //S�L�[���������炵�Ⴊ��
        if (Input.GetKey(KeyCode.S))
        {
            anim.SetBool("crouch", true);
        }
        //����ȊO�͂��Ⴊ�݂���������
        else
        {
            anim.SetBool("crouch", false);
        }

    }

   
}
