using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class overBGM : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string scenename = PlayerPrefs.GetString("GAMEOVER1");
        {
            //�I�[�o�[���BGM
            SoundManager.soundManager.PlayBgm(BGMType.GAMEover);
        }
    }
}
