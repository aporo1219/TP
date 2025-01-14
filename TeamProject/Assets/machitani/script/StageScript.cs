using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageScript : MonoBehaviour
{
    public int stage_num;
    public GameObject Stageone;
    public GameObject StageoneShadow;
    public GameObject Stagetwo;
    public GameObject StagetwoShadow;
    public GameObject Stagethree;
    public GameObject StagethreeShadow;
    public GameObject Stagefour;
    public GameObject StagefourShadow;
    public GameObject Stagefive;
    public GameObject StagefiveShadow;

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
            //ステージ2(影)を出す
            StagetwoShadow.SetActive(true);
            //ステージ1を出す
            Stageone.SetActive(true);
            //ステージ2(影)を消す
            StageoneShadow.SetActive(false);
        }
        //ステージ2をクリアしたなら
        if (stage_num >= 2) 
        {
            //ステージ3(影)を出す
            StagethreeShadow.SetActive(true);
            //ステージ2を出す
            Stagetwo.SetActive(true);
            //ステージ2(影)を消す
            StagetwoShadow.SetActive(false);
        }
        //ステージ3をクリアしたなら
        if (stage_num >= 3)
        {
            //ステージ4(影)を出す
            StagefourShadow.SetActive(true);
            //ステージ3を出す
            Stagethree.SetActive(true);
            //ステージ3(影)を消す
            StagethreeShadow.SetActive(false);
        }
        //ステージ4をクリアしたなら
        if (stage_num >= 4)
        {
            //ステージ5(影)を出す
            StagefiveShadow.SetActive(true);
            //ステージ4を出す
            Stagefour.SetActive(true);
            //ステージ4(影)を消す
            StagefourShadow.SetActive(false);
        }
        //ステージ5をクリアしたなら
        if(stage_num>=5)
        {
            //ステージ5を出す
            Stagefive.SetActive(true);
            //ステージ5(影)を消す
            StagefiveShadow.SetActive(false);
        }
    }
}
