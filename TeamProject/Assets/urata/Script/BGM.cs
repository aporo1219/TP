using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour
{
    public string sceneName = ""; //�V�[����
    // Start is called before the first frame update
    void Start()
    {
        if(sceneName == "Title")//�^�C�g���V�[��������ΐ؂�ւ���
        {
            //�^�C�g��BGM
            SoundManager.soundManager.PlayBgm(BGMType.titlemusic);
        }
        else if (sceneName == "game�@select")//�Z���N�g�V�[��������ΐ؂�ւ���
        {
            //�Z���N�gBGM
            SoundManager.soundManager.PlayBgm(BGMType.selectscreen);
        }
        else if (sceneName == "operation")//�`���[�g���A���V�[��������ΐ؂�ւ���
        {
            //�`���[�g���A��BGM
            SoundManager.soundManager.PlayBgm(BGMType.tutorial);
        }
        else if (sceneName == "STAGE")//�Q�[���{�҃V�[��������ΐ؂�ւ���
        {
            //���C��BGM
            SoundManager.soundManager.PlayBgm(BGMType.GAMEmain);
        }
        else if (sceneName == "GAMECLEAR1")//�Q�[���N���A�V�[��������ΐ؂�ւ���
        {
            //�N���ABGM
            SoundManager.soundManager.PlayBgm(BGMType.GAMEclear);
        }
        else if (sceneName == "GAMEOVER1")//�Q�[���I�[�o�[�V�[��������ΐ؂�ւ���
        {
            //�I�[�o�[���BGM
            SoundManager.soundManager.PlayBgm(BGMType.GAMEover);
        }
        else if(sceneName == "RANKING")//�����L���O�V�[��������ΐ؂�ւ���
        {
            //�����L���OBGM
            SoundManager.soundManager.PlayBgm(BGMType.Ranking);
        }
    }
}