using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class clearBGM : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string scenename = PlayerPrefs.GetString("GAMECLEAR1");
        {
            //�N���ABGM
            SoundManager.soundManager.PlayBgm(BGMType.GAMEclear);
        }
    }
}
