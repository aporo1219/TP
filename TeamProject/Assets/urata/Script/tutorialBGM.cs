using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tutorialBGM : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string scenename = PlayerPrefs.GetString("operation");
        {
            //チュートリアルBGM
            SoundManager.soundManager.PlayBgm(BGMType.tutorial);
        }
    }
}