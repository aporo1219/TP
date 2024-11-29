using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainBGM : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //ƒ^ƒCƒgƒ‹BGM
        SoundManager.soundManager.PlayBgm(BGMType.GAMEmain);
    }
}