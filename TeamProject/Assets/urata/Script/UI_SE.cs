using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_SE : MonoBehaviour
{
    //�}�E�X�ŃN���b�N����Ɖ�����

    public bool DontDestroyEnabled = true;//�ϐ��錾
    // Start is called before the first frame update
    void Start()
    {
        if (DontDestroyEnabled)
        {
            //Scene��J�ڂ��Ă��I�u�W�F�N�g�������Ȃ��悤�ɂ���
            DontDestroyOnLoad(this);
        }
    }
    // Update is called once per frame
    void Update()
    {
        //�����}�E�X�������ꂽ��
        if (Input.GetMouseButtonDown(0))
        {
            //SE���Đ�����
            GetComponent<AudioSource>().Play();
        }
    }
}