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
        //�X�e�[�W1���N���A�����Ȃ�
        if (stage_num >= 1) 
        {
            //�X�e�[�W2(�e)���o��
            StagetwoShadow.SetActive(true);
            //�X�e�[�W1���o��
            Stageone.SetActive(true);
            //�X�e�[�W2(�e)������
            StageoneShadow.SetActive(false);
        }
        //�X�e�[�W2���N���A�����Ȃ�
        if (stage_num >= 2) 
        {
            //�X�e�[�W3(�e)���o��
            StagethreeShadow.SetActive(true);
            //�X�e�[�W2���o��
            Stagetwo.SetActive(true);
            //�X�e�[�W2(�e)������
            StagetwoShadow.SetActive(false);
        }
        //�X�e�[�W3���N���A�����Ȃ�
        if (stage_num >= 3)
        {
            //�X�e�[�W4(�e)���o��
            StagefourShadow.SetActive(true);
            //�X�e�[�W3���o��
            Stagethree.SetActive(true);
            //�X�e�[�W3(�e)������
            StagethreeShadow.SetActive(false);
        }
        //�X�e�[�W4���N���A�����Ȃ�
        if (stage_num >= 4)
        {
            //�X�e�[�W5(�e)���o��
            StagefiveShadow.SetActive(true);
            //�X�e�[�W4���o��
            Stagefour.SetActive(true);
            //�X�e�[�W4(�e)������
            StagefourShadow.SetActive(false);
        }
        //�X�e�[�W5���N���A�����Ȃ�
        if(stage_num>=5)
        {
            //�X�e�[�W5���o��
            Stagefive.SetActive(true);
            //�X�e�[�W5(�e)������
            StagefiveShadow.SetActive(false);
        }
    }
}
