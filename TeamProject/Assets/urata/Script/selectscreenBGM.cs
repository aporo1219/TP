using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class selectscreenBGM : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string scenename = PlayerPrefs.GetString("game　select");
        {
            //セレクトBGM
            SoundManager.soundManager.PlayBgm(BGMType.selectscreen);
        }
    }
}