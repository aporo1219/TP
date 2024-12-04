using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//BGMタイプ
public enum BGMType
{
    Noue,//なし
    titlemusic,     //タイトル
    selectscreen,   //セレクト画面
    GAMEmain,       //ゲーム本編
    GAMEclear,      //ゲームクリア
    GAMEover,       //ゲームオーバー
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
    UImusic,        //各UIを押した場合の音
}

public class SoundManager:MonoBehaviour
{
    //BGM
    public AudioClip bgmIntitlemusic;       //タイトル
    public AudioClip bgmInselectscreen;     //セレクト画面
    public AudioClip bgmInGAMEmain;         //ゲーム本編
    public AudioClip bgmInGAMEclear;        //ゲームクリア
    public AudioClip bgmInGAMEover;         //ゲームオーバー
    public AudioClip bgmIntutorial;         //チュートリアル
    public AudioClip bgmInRanking;          //ランキング
    //SE
    public AudioClip sejump;                //ジャンプ
    public AudioClip secrouch;              //しゃがむ
    public AudioClip sedamage;              //当たった時の音
    public AudioClip serecovery;            //回復音
    public AudioClip meUImusic;             //各UIを押した場合の音

    public static SoundManager soundManager;//最初のSoundManagerを保存する

    public static BGMType plyingBGM = BGMType.Noue;//再生中のBGM

    private void Awake()
    {
        //BGM再生
        if (soundManager == null)
        {
            soundManager = this;//staic変数に自分を保存する
        }
        else
        {
            Destroy(gameObject);//ゲームオブジェクトの破壊
        }
    }

    //BGM設定
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
            else if (type == BGMType.GAMEmain)
            {
                audio.clip = bgmInGAMEmain;//ゲーム本編
            }
            else if (type == BGMType.GAMEclear)
            {
                audio.clip = bgmInGAMEclear;//ゲームクリア
            }
            else if (type == BGMType.GAMEover)
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
    //BGM停止
    public void StopBgm()
    {
        GetComponent<AudioSource>().Stop();
        plyingBGM = BGMType.Noue;
    }

    //SE再生
    public void SEPlay(SEType type)
    {
        if(type == SEType.jump)
        {
            GetComponent<AudioSource>().PlayOneShot(sejump);//ジャンプ
        }
        else if(type == SEType.crouch)
        {
            GetComponent <AudioSource>().PlayOneShot(secrouch);//しゃがむ
        }
        else if (type == SEType.damage)
        {
            GetComponent < AudioSource >().PlayOneShot(sedamage);//当たった時の音
        }
        else if (type == SEType.recovery)
        {
            GetComponent < AudioSource >().PlayOneShot(serecovery);//回復音
        }
        else if (type == SEType.UImusic)
        {
            GetComponent < AudioSource >().PlayOneShot(meUImusic);//各UIを押した場合の音
        }
    }
}
