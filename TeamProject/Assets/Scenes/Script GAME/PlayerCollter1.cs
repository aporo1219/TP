using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollter1 : MonoBehaviour
{
    
    //���Ⴊ��
    private Animator anim = null;
    public BoxCollider2D Hit_Judgment;
   

    void Start()
    {
        //���Ⴊ�ރA�j���[�V�����̏�����
        anim = GetComponent<Animator>();
        Hit_Judgment = GetComponent<BoxCollider2D>();
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


        if(CalorieTEXT.Fnish == 1)
        {
            Hit_Judgment.enabled = false;
        }
    }

   
}
