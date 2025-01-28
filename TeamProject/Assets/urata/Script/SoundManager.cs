using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//BGM�ESE�ݒ�

//BGM�^�C�v
public enum BGMType
{
    Noue,           //�Ȃ�
    titlemusic,     //�^�C�g��
    selectscreen,   //�Z���N�g���
    gamemain,       //�Q�[���{��
    gameclear,      //�Q�[���N���A
    gameover,       //�Q�[���I�[�o�[
    tutorial,       //�`���[�g���A��
    Ranking,        //�����L���O
}
//SE�^�C�v
public enum SEType
{
    jump,           //�W�����v
    crouch,         //���Ⴊ��
    damage,         //�����������̉�
    recovery,       //�񕜉�
}

public class SoundManager:MonoBehaviour
{
    //�ϐ��錾

    //BGM
    public AudioClip bgmIntitlemusic;       //�^�C�g��
    public AudioClip bgmInselectscreen;     //�Z���N�g���
    public AudioClip bgmInGAMEmain;         //�Q�[���{��
    public AudioClip bgmInGAMEclear;        //�Q�[���N���A
    public AudioClip bgmInGAMEover;         //�Q�[���I�[�o�[
    public AudioClip bgmIntutorial;         //�`���[�g���A��
    public AudioClip bgmInRanking;          //�����L���O
    //SE
    public AudioClip seJump;                //�W�����v
    public AudioClip seCrouch;              //���Ⴊ��
    public AudioClip seDamage;              //�����������̉�
    public AudioClip seRecovery;            //�񕜉�

    public static SoundManager soundManager;//�ŏ���SoundManager��ۑ�����

    public static BGMType plyingBGM = BGMType.Noue;//�Đ�����BGM

    private void Awake()
    {
        //BGM�Đ�
        if (soundManager == null)
        {
            soundManager = this;//staic�ϐ��Ɏ�����ۑ�����
        }
    }

    //BGM�ݒ�
    //����
    //������
    public void PlayBgm(BGMType type)
    {
        if(type != plyingBGM)
        {
            plyingBGM = type;
            AudioSource audio = GetComponent<AudioSource>();
            if(type == BGMType.titlemusic)
            {
                audio.clip = bgmIntitlemusic;//�^�C�g��
            }
            else if (type == BGMType.selectscreen)
            {
                audio.clip = bgmInselectscreen;//�Z���N�g���
            }
            else if (type == BGMType.gamemain)
            {
                audio.clip = bgmInGAMEmain;//�Q�[���{��
            }
            else if (type == BGMType.gameclear)
            {
                audio.clip = bgmInGAMEclear;//�Q�[���N���A
            }
            else if (type == BGMType.gameover)
            {
                audio.clip = bgmInGAMEover;//�Q�[���I�[�o�[
            }
            else if (type == BGMType.tutorial)
            {
                audio.clip = bgmIntutorial;//�`���[�g���A��
            }
            else if (type == BGMType.Ranking)
            {
                audio.clip = bgmInRanking;//�����L���O
            }
            audio.Play();
        }
    }

    //SE�Đ�
    public void SEPlay(SEType type)
    {
        if(type == SEType.jump)
        {
            GetComponent<AudioSource>().PlayOneShot(seJump);//�W�����v
        }
        else if(type == SEType.crouch)
        {
            GetComponent <AudioSource>().PlayOneShot(seCrouch);//���Ⴊ��
        }
        else if (type == SEType.damage)
        {
            GetComponent < AudioSource >().PlayOneShot(seDamage);//�����������̉�
        }
        else if (type == SEType.recovery)
        {
            GetComponent < AudioSource >().PlayOneShot(seRecovery);//�񕜉�
        }
    }
}
