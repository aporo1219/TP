using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Mouse1 : MonoBehaviour
{
    private int numberTITLE;
    private int numberGAMEOVER;
    private int numberGAMECLEAR;
    private int numberRANKING;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;//�J�[�\����\��
        Cursor.lockState = CursorLockMode.Locked;//�J�[�\���@�\�Ȃ�
    }

    // Update is called once per frame
    void Update()
    {
        //�V�[�����^�C�g���̎�
        if (SceneManager.GetActiveScene().name == "Title")
        {
            Cursor.visible = true;//�J�[�\���\��
            Cursor.lockState = CursorLockMode.None;//�J�[�\���@�\����
            ClickGN(numberTITLE);
        }
        //�V�[�����Q�[���I�[�o�[�̎�
        if (SceneManager.GetActiveScene().name == "GAMEOVER1")
        {
            Cursor.visible = true;//�J�[�\���\��
            Cursor.lockState = CursorLockMode.None;//�J�[�\���@�\����
            ClickGO(numberGAMEOVER);
        }
        //�V�[�����Q�[���N���A�̎�
        if (SceneManager.GetActiveScene().name == "GAMECLEAR1")
        {
            Cursor.visible = true;//�J�[�\���\��
            Cursor.lockState = CursorLockMode.None;//�J�[�\���@�\����
            ClickGC(numberGAMECLEAR);
        }
        //�V�[���������L���O�̎�
        if (SceneManager.GetActiveScene().name == "RANKING")
        {
            Cursor.visible = true;//�J�[�\���\��
            Cursor.lockState = CursorLockMode.None;//�J�[�\���@�\����
            ClickB(numberRANKING);
        }
    }

    //�^�C�g���̃{�^���֐�
    public void ClickGN(int TITLEBUTTON)
    {
        switch (TITLEBUTTON)
        {
            case 1:
                //�Q�[���Z���N�g�փ{�^���̏���
                SceneManager.LoadScene("game select");
                break;

            default:
                break;
        }
    }
    //�Q�[���I�[�o�[�V�[���̃{�^���֐�
    public void ClickGO(int OVERBUTTON)
    {
        switch (OVERBUTTON)
        {
            case 1:
                //�߂�{�^���̏���
                if(CalorieTEXT.StageInfor == 0)
                {
                  SceneManager.LoadScene("STAGE1");
                }
                if (CalorieTEXT.StageInfor == 1)
                {
                    SceneManager.LoadScene("STAGE2");
                }
                if (CalorieTEXT.StageInfor == 2)
                {
                    SceneManager.LoadScene("STAGE3");
                }
                if (CalorieTEXT.StageInfor == 3)
                {
                    SceneManager.LoadScene("STAGE4");
                }
                if (CalorieTEXT.StageInfor == 4)
                {
                    SceneManager.LoadScene("STAGE5");
                }
                break;
            case 2:
                //�^�C�g���ɖ߂�{�^���̏���
                SceneManager.LoadScene("Title");
                break;
            default:
                break;
        }
    }
    //�Q�[���N���A�̃{�^���֐�
    public void ClickGC(int CLEARBUTTON)
    {
        switch (CLEARBUTTON)
        {
            case 1:
                //�X�e�[�W�Z���N�g�ւ̃{�^���̏���
                SceneManager.LoadScene("game select");
                break;
            case 2:
                //�^�C�g���ɖ߂�{�^���̏���
                SceneManager.LoadScene("Title");
                break;
            case 3:
                //�����L���O�\���{�^���̏���
                SceneManager.LoadScene("RANKING");
                break;
            default:
                break;
        }
    }
    //�����L���O�V�[���̃{�^���֐�
    public void ClickB(int RANKINGBUTTON)
    {
        switch (RANKINGBUTTON)
        {
            case 1:
                //�Q�[���N���A�ɖ߂�{�^���̏���
                SceneManager.LoadScene("GAMECLEAR1");
                break;
            default:
                break;
        }
    }
}



