using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageScript : MonoBehaviour
{
    public int stage_num;
    public GameObject ni;
    public GameObject san;
    public GameObject yon;
    public GameObject go;

    // Start is called before the first frame update
    void Start()
    {
        stage_num = PlayerPrefs.GetInt("SCORE", 0);
    }

    // Update is called once per frame
    void Update()
    {
        //ステージ1をクリアしたなら
        if (stage_num >= 1) 
        {
            //ステージ2を出す
            ni.SetActive(true);
        }
        //ステージ2をクリアしたなら
        if (stage_num >= 2) 
        {
            //ステージ3を出す
            san.SetActive(true);
        }
        //ステージ3をクリアしたなら
        if (stage_num >= 3)
        {
            //ステージ4を出す
            yon.SetActive(true);
        }
        //ステージ4をクリアしたなら
        if (stage_num >= 4)
        {
            //ステージ5を出す
            go.SetActive(true);
        }
    }
}
