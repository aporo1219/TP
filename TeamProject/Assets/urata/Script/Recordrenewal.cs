using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Recordrenewal :RANKING
{
    //�n�C�X�R�A�X�V���Ƀ��b�Z�[�W���o������
    public Text Messagetext;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //�N���A�����X�e�[�W�ɂ���Ẵx�X�g�J�����[�ʂ̕\��
        if (CalorieTEXT.StageInfor == 0)
        {
            Text1();
        }
        if (CalorieTEXT.StageInfor == 1)
        {
            Text2();
        }
        if (CalorieTEXT.StageInfor == 2)
        {
            Text3();
        }
        if (CalorieTEXT.StageInfor == 3)
        {
            Text4();
        }
        if (CalorieTEXT.StageInfor == 4)
        {
            Text5();
        }
    }

    void Text1()
    {
        //RANKING�X�e�[�W1�̕ϐ����J�����[�e�L�X�g�̐������傫���ƃe�L�X�g��\���������𖞂����ĂȂ��ꍇ�e�L�X�g���\���ɂ���
        if (CalorieTEXT.CalorieTEXTInitival > RANKING.HC1)
        {
            Messagetext.enabled = true;// �e�L�X�g��\��
        }
        else
        {
            Messagetext.enabled = false;// �e�L�X�g���\��
        }
    }

    void Text2()
    {
        //RANKING�X�e�[�W2�̕ϐ����J�����[�e�L�X�g�̐������傫���ƃe�L�X�g��\���������𖞂����ĂȂ��ꍇ�e�L�X�g���\���ɂ���
        if (CalorieTEXT.CalorieTEXTInitival > RANKING.HC2)
        {
            Messagetext.enabled = true;// �e�L�X�g��\��
        }
        else
        {
            Messagetext.enabled = false;// �e�L�X�g���\��
        }
    }

    void Text3()
    {
        //RANKING�X�e�[�W3�̕ϐ����J�����[�e�L�X�g�̐������傫���ƃe�L�X�g��\���������𖞂����ĂȂ��ꍇ�e�L�X�g���\���ɂ���
        if (CalorieTEXT.CalorieTEXTInitival > RANKING.HC3)
        {
            Messagetext.enabled = true;// �e�L�X�g��\��
        }
        else
        {
            Messagetext.enabled = false;// �e�L�X�g���\��
        }
    }

    void Text4()
    {
        //RANKING�X�e�[�W4�̕ϐ����J�����[�e�L�X�g�̐������傫���ƃe�L�X�g��\���������𖞂����ĂȂ��ꍇ�e�L�X�g���\���ɂ���
        if (CalorieTEXT.CalorieTEXTInitival > RANKING.HC4)
        {
            Messagetext.enabled = true;// �e�L�X�g��\��
        }
        else
        {
            Messagetext.enabled = false;// �e�L�X�g���\��
        }
    }

    void Text5()
    {
        //RANKING�X�e�[�W�̕ϐ����J�����[�e�L�X�g�̐������傫���ƃe�L�X�g��\���������𖞂����ĂȂ��ꍇ�e�L�X�g���\���ɂ���
        if (CalorieTEXT.CalorieTEXTInitival > RANKING.HC5)
        {
            Messagetext.enabled = true;// �e�L�X�g��\��
        }
        else
        {
            Messagetext.enabled = false;// �e�L�X�g���\��
        }
    }

}