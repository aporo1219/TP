using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_SE : MonoBehaviour
{
    //マウスでクリックすると音が鳴る

    public bool DontDestroyEnabled = true;//変数宣言
    // Start is called before the first frame update
    void Start()
    {
        if (DontDestroyEnabled)
        {
            //Sceneを遷移してもオブジェクトが消えないようにする
            DontDestroyOnLoad(this);
        }
    }
    // Update is called once per frame
    void Update()
    {
        //もしマウスが押されたら
        if (Input.GetMouseButtonDown(0))
        {
            //SEを再生する
            GetComponent<AudioSource>().Play();
        }
    }
}