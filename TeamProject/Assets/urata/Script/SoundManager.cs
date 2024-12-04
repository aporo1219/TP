using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//BGM�^�C�v
public enum BGMType
{
    Noue,//�Ȃ�
    titlemusic,     //�^�C�g��
    selectscreen,   //�Z���N�g���
    GAMEmain,       //�Q�[���{��
    GAMEclear,      //�Q�[���N���A
    GAMEover,       //�Q�[���I�[�o�[
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
    UImusic,        //�eUI���������ꍇ�̉�
}

public class SoundManager:MonoBehaviour
{
    //BGM
    public AudioClip bgmIntitlemusic;       //�^�C�g��
    public AudioClip bgmInselectscreen;     //�Z���N�g���
    public AudioClip bgmInGAMEmain;         //�Q�[���{��
    public AudioClip bgmInGAMEclear;        //�Q�[���N���A
    public AudioClip bgmInGAMEover;         //�Q�[���I�[�o�[
    public AudioClip bgmIntutorial;         //�`���[�g���A��
    public AudioClip bgmInRanking;          //�����L���O
    //SE
    public AudioClip sejump;                //�W�����v
    public AudioClip secrouch;              //���Ⴊ��
    public AudioClip sedamage;              //�����������̉�
    public AudioClip serecovery;            //�񕜉�
    public AudioClip meUImusic;             //�eUI���������ꍇ�̉�

    public static SoundManager soundManager;//�ŏ���SoundManager��ۑ�����

    public static BGMType plyingBGM = BGMType.Noue;//�Đ�����BGM

    private void Awake()
    {
        //BGM�Đ�
        if (soundManager == null)
        {
            soundManager = this;//staic�ϐ��Ɏ�����ۑ�����
        }
        else
        {
            Destroy(gameObject);//�Q�[���I�u�W�F�N�g�̔j��
        }
    }

    //BGM�ݒ�
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
            else if (type == BGMType.GAMEmain)
            {
                audio.clip = bgmInGAMEmain;//�Q�[���{��
            }
            else if (type == BGMType.GAMEclear)
            {
                audio.clip = bgmInGAMEclear;//�Q�[���N���A
            }
            else if (type == BGMType.GAMEover)
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
    //BGM��~
    public void StopBgm()
    {
        GetComponent<AudioSource>().Stop();
        plyingBGM = BGMType.Noue;
    }

    //SE�Đ�
    public void SEPlay(SEType type)
    {
        if(type == SEType.jump)
        {
            GetComponent<AudioSource>().PlayOneShot(sejump);//�W�����v
        }
        else if(type == SEType.crouch)
        {
            GetComponent <AudioSource>().PlayOneShot(secrouch);//���Ⴊ��
        }
        else if (type == SEType.damage)
        {
            GetComponent < AudioSource >().PlayOneShot(sedamage);//�����������̉�
        }
        else if (type == SEType.recovery)
        {
            GetComponent < AudioSource >().PlayOneShot(serecovery);//�񕜉�
        }
        else if (type == SEType.UImusic)
        {
            GetComponent < AudioSource >().PlayOneShot(meUImusic);//�eUI���������ꍇ�̉�
        }
    }
}
