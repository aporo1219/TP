using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//BGM・SE設定

//BGMタイプ
/// <summary>
/// ここからBGMが呼ばれる
/// </summary>
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
    Highscore,      //記録更新
}
//SEタイプ
/// <summary>
/// 
/// </summary>
public enum SEType
{
    jump,           //ジャンプ
    crouch,         //しゃがむ
    damage,         //当たった時の音
    recovery,       //回復音
}

/// <summary>
/// 
/// </summary>
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
    public AudioClip bgmInhighscore;        //ランキング
    //SE
    public AudioClip seJump;                //ジャンプ
    public AudioClip seCrouch;              //しゃがむ
    public AudioClip seDamage;              //当たった時の音
    public AudioClip seRecovery;            //回復音

    public static SoundManager soundManager;//最初のSoundManagerを保存する

    public static BGMType plyingBGM = BGMType.Noue;//再生中のBGM

    /// <summary>
    /// 
    /// </summary>
    private void Awake()
    {
        //BGM再生
        if (soundManager == null)
        {
            soundManager = this;//staic変数に自分を保存する
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="type"></param>
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
            else if(type == BGMType.Highscore)
            {
                audio.clip = bgmInhighscore;//記録更新
            }
            audio.Play();
        }
    }

    //SE再生
    /// <summary>
    /// 
    /// </summary>
    /// <param name="type"></param>
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
