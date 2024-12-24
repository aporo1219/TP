using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_SE : MonoBehaviour
{
    //マウスでクリックすると音が鳴る

    public bool DontDestroyEnabled = true;
    // Start is called before the first frame update
    void Start()
    {
        if (DontDestroyEnabled)
        {
            // Sceneを遷移してもオブジェクトが消えないようにする
            DontDestroyOnLoad(this);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GetComponent<AudioSource>().Play();
        }
        else if(Input.GetMouseButtonUp(0))
        {
            GetComponent<AudioSource>().Stop();
        }
    }
}
