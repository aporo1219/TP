using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//BGM・SE設定

//BGMタイプ
public enum BGMType
{
    Noue,           //なし
    titlemusic,     //タイトル
    selectscreen,   //セレクト画面
    gamemain,       //ゲーム本編
    gameclear,      //ゲームクリア
    gameover,       //ゲームオーバー
    tutorial,       //チュートリアル
    Ranking,        //ランキング
}
//SEタイプ
public enum SEType
{
    jump,           //ジャンプ
    crouch,         //しゃがむ
    damage,         //当たった時の音
    recovery,       //回復音
}

public class SoundManager:MonoBehaviour
{
    //変数宣言

    //BGM
    public AudioClip bgmIntitlemusic;       //タイトル
    public AudioClip bgmInselectscreen;     //セレクト画面
    public AudioClip bgmInGAMEmain;         //ゲーム本編
    public AudioClip bgmInGAMEclear;        //ゲームクリア
    public AudioClip bgmInGAMEover;         //ゲームオーバー
    public AudioClip bgmIntutorial;         //チュートリアル
    public AudioClip bgmInRanking;          //ランキング
    //SE
    public AudioClip seJump;                //ジャンプ
    public AudioClip seCrouch;              //しゃがむ
    public AudioClip seDamage;              //当たった時の音
    public AudioClip seRecovery;            //回復音

    public static SoundManager soundManager;//最初のSoundManagerを保存する

    public static BGMType plyingBGM = BGMType.Noue;//再生中のBGM

    private void Awake()
    {
        //BGM再生
        if (soundManager == null)
        {
            soundManager = this;//staic変数に自分を保存する
        }
    }

    //BGM設定
    //説明
    //引数名
    public void PlayBgm(BGMType type)
    {
        if(type != plyingBGM)
        {
            plyingBGM = type;
            AudioSource audio = GetComponent<AudioSource>();
            if(type == BGMType.titlemusic)
            {
                audio.clip = bgmIntitlemusic;//タイトル
            }
            else if (type == BGMType.selectscreen)
            {
                audio.clip = bgmInselectscreen;//セレクト画面
            }
            else if (type == BGMType.gamemain)
            {
                audio.clip = bgmInGAMEmain;//ゲーム本編
            }
            else if (type == BGMType.gameclear)
            {
                audio.clip = bgmInGAMEclear;//ゲームクリア
            }
            else if (type == BGMType.gameover)
            {
                audio.clip = bgmInGAMEover;//ゲームオーバー
            }
            else if (type == BGMType.tutorial)
            {
                audio.clip = bgmIntutorial;//チュートリアル
            }
            else if (type == BGMType.Ranking)
            {
                audio.clip = bgmInRanking;//ランキング
            }
            audio.Play();
        }
    }

    //SE再生
    public void SEPlay(SEType type)
    {
        if(type == SEType.jump)
        {
            GetComponent<AudioSource>().PlayOneShot(seJump);//ジャンプ
        }
        else if(type == SEType.crouch)
        {
            GetComponent <AudioSource>().PlayOneShot(seCrouch);//しゃがむ
        }
        else if (type == SEType.damage)
        {
            GetComponent < AudioSource >().PlayOneShot(seDamage);//当たった時の音
        }
        else if (type == SEType.recovery)
        {
            GetComponent < AudioSource >().PlayOneShot(seRecovery);//回復音
        }
    }
}
