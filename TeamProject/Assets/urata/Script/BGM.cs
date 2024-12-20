using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour
{
    public string sceneName = ""; //シーン名
    // Start is called before the first frame update
    void Start()
    {
        if(sceneName == "Title")//タイトルシーンがあれば切り替える
        {
            //タイトルBGM
            SoundManager.soundManager.PlayBgm(BGMType.titlemusic);
        }
        else if (sceneName == "game　select")//セレクトシーンがあれば切り替える
        {
            //セレクトBGM
            SoundManager.soundManager.PlayBgm(BGMType.selectscreen);
        }
        else if (sceneName == "operation")//チュートリアルシーンがあれば切り替える
        {
            //チュートリアルBGM
            SoundManager.soundManager.PlayBgm(BGMType.tutorial);
        }
        else if (sceneName == "STAGE")//ゲーム本編シーンがあれば切り替える
        {
            //メインBGM
            SoundManager.soundManager.PlayBgm(BGMType.GAMEmain);
        }
        else if (sceneName == "GAMECLEAR1")//ゲームクリアシーンがあれば切り替える
        {
            //クリアBGM
            SoundManager.soundManager.PlayBgm(BGMType.GAMEclear);
        }
        else if (sceneName == "GAMEOVER1")//ゲームオーバーシーンがあれば切り替える
        {
            //オーバー画面BGM
            SoundManager.soundManager.PlayBgm(BGMType.GAMEover);
        }
        else if(sceneName == "RANKING")//ランキングシーンがあれば切り替える
        {
            //ランキングBGM
            SoundManager.soundManager.PlayBgm(BGMType.Ranking);
        }
    }
}