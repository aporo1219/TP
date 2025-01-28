using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour
{
    //�e�V�[����BGM�ݒ�

    public string sceneName = ""; //�V�[����
    // Start is called before the first frame update
    void Start()
    {
        if(sceneName == "title")//�^�C�g���V�[��������ΐ؂�ւ���
        {
            //�^�C�g��BGM
            SoundManager.soundManager.PlayBgm(BGMType.titlemusic);
        }
        else if (sceneName == "gameselect")//�Z���N�g�V�[��������ΐ؂�ւ���
        {
            //�Z���N�gBGM
            SoundManager.soundManager.PlayBgm(BGMType.selectscreen);
        }
        else if (sceneName == "operation")//�`���[�g���A���V�[��������ΐ؂�ւ���
        {
            //�`���[�g���A��BGM
            SoundManager.soundManager.PlayBgm(BGMType.tutorial);
        }
        else if (sceneName == "stsge")//�Q�[���{�҃V�[��������ΐ؂�ւ���
        {
            //���C��BGM
            SoundManager.soundManager.PlayBgm(BGMType.gamemain);
        }
        else if (sceneName == "gameclear1")//�Q�[���N���A�V�[��������ΐ؂�ւ���
        {
            //�N���ABGM
            SoundManager.soundManager.PlayBgm(BGMType.gameclear);
        }
        else if (sceneName == "gameover1")//�Q�[���I�[�o�[�V�[��������ΐ؂�ւ���
        {
            //�I�[�o�[���BGM
            SoundManager.soundManager.PlayBgm(BGMType.gameover);
        }
        else if(sceneName == "ranking")//�����L���O�V�[��������ΐ؂�ւ���
        {
            //�����L���OBGM
            SoundManager.soundManager.PlayBgm(BGMType.Ranking);
        }
    }
}