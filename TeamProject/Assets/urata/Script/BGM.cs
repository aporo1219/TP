using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour
{
    //各シーンのBGM設定

    public string sceneName = ""; //シーン名
    // Start is called before the first frame update
    void Start()
    {
        if(sceneName == "title")//タイトルシーンがあれば切り替える
        {
            //タイトルBGM
            SoundManager.soundManager.PlayBgm(BGMType.titlemusic);
        }
        else if (sceneName == "gameselect")//セレクトシーンがあれば切り替える
        {
            //セレクトBGM
            SoundManager.soundManager.PlayBgm(BGMType.selectscreen);
        }
        else if (sceneName == "operation")//チュートリアルシーンがあれば切り替える
        {
            //チュートリアルBGM
            SoundManager.soundManager.PlayBgm(BGMType.tutorial);
        }
        else if (sceneName == "stsge")//ゲーム本編シーンがあれば切り替える
        {
            //メインBGM
            SoundManager.soundManager.PlayBgm(BGMType.gamemain);
        }
        else if (sceneName == "gameclear1")//ゲームクリアシーンがあれば切り替える
        {
            //クリアBGM
            SoundManager.soundManager.PlayBgm(BGMType.gameclear);
        }
        else if (sceneName == "gameover1")//ゲームオーバーシーンがあれば切り替える
        {
            //オーバー画面BGM
            SoundManager.soundManager.PlayBgm(BGMType.gameover);
        }
        else if(sceneName == "ranking")//ランキングシーンがあれば切り替える
        {
            //ランキングBGM
            SoundManager.soundManager.PlayBgm(BGMType.Ranking);
        }
    }
}