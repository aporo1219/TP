using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Mouse1 : MonoBehaviour
{
    private int number_TITLE;//�^�C�g���̃{�^���p�̈���
    private int number_GAMEOVER;//�Q�[���I�[�o�[�̃{�^���p�̈���
    private int number_GAMECLEAR;//�Q�[���N���A�̃{�^���p�̈���
    private int number_RANKING;//�����L���O�̃{�^���p�̈���
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
            ClickGN(number_TITLE);
        }
        //�V�[�����Q�[���I�[�o�[�̎�
        if (SceneManager.GetActiveScene().name == "GAMEOVER1")
        {
            Cursor.visible = true;//�J�[�\���\��
            Cursor.lockState = CursorLockMode.None;//�J�[�\���@�\����
            ClickGO(number_GAMEOVER);
        }
        //�V�[�����Q�[���N���A�̎�
        if (SceneManager.GetActiveScene().name == "GAMECLEAR1")
        {
            Cursor.visible = true;//�J�[�\���\��
            Cursor.lockState = CursorLockMode.None;//�J�[�\���@�\����
            ClickGC(number_GAMECLEAR);
        }
        //�V�[���������L���O�̎�
        if (SceneManager.GetActiveScene().name == "RANKING")
        {
            Cursor.visible = true;//�J�[�\���\��
            Cursor.lockState = CursorLockMode.None;//�J�[�\���@�\����
            ClickB(number_RANKING);
        }
    }

    //�^�C�g���̃{�^���֐�
    public void ClickGN(int TITLE_BUTTON)
    {
        switch (TITLE_BUTTON)
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
    public void ClickGO(int OVER_BUTTON)
    {
        switch (OVER_BUTTON)
        {
            case 1:
                //�߂�{�^���̏���
                //���s�����X�e�[�W�ɖ߂邽�߃X�e�[�W�����擾���A�����Ă���
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
    public void ClickGC(int CLEAR_BUTTON)
    {
        switch (CLEAR_BUTTON)
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
    public void ClickB(int RANKING_BUTTON)
    {
        switch (RANKING_BUTTON)
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



