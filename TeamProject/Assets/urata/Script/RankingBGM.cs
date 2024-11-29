using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RankingBGM : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string scenename = PlayerPrefs.GetString("RANKING");
        {
            //ƒ‰ƒ“ƒLƒ“ƒOBGM
            SoundManager.soundManager.PlayBgm(BGMType.Ranking);
        }
    }
}
