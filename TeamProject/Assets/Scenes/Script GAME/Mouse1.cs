using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Mouse1 : MonoBehaviour
{
    private int number0;
    private int number;
    private int number1;
    private int number2;
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
            ClickGN(number0);
        }
        //�V�[�����Q�[���I�[�o�[�̎�
        if (SceneManager.GetActiveScene().name == "GAMEOVER1")
        {
            Cursor.visible = true;//�J�[�\���\��
            Cursor.lockState = CursorLockMode.None;//�J�[�\���@�\����
            ClickGO(number);
        }
        //�V�[�����Q�[���N���A�̎�
        if (SceneManager.GetActiveScene().name == "GAMECLEAR1")
        {
            Cursor.visible = true;//�J�[�\���\��
            Cursor.lockState = CursorLockMode.None;//�J�[�\���@�\����
            ClickGC(number1);
        }
        //�V�[���������L���O�̎�
        if (SceneManager.GetActiveScene().name == "RANKING")
        {
            Cursor.visible = true;//�J�[�\���\��
            Cursor.lockState = CursorLockMode.None;//�J�[�\���@�\����
            ClickB(number2);
        }
    }

    //�^�C�g���̃{�^���֐�
    public void ClickGN(int N0)
    {
        switch (N0)
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
    public void ClickGO(int N)
    {
        switch (N)
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
    public void ClickGC(int N1)
    {
        switch (N1)
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
    public void ClickB(int N2)
    {
        switch (N2)
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



