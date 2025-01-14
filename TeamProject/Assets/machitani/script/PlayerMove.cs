using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //����
     private float STEP = 3.0f;
    //���Ⴊ��
    private Animator anim = null;

    void Start()
    {
        //�A�j���[�V����
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        //�����L�[���������炵�Ⴊ��
        if (Input.GetKey(KeyCode.S))
        {
            anim.SetBool("crouch", true);
        }
        else
        {
            anim.SetBool("crouch", false);
        }
        //�E����
        this.transform.position += new Vector3(STEP * Time.deltaTime, 0, 0);
    }
}
