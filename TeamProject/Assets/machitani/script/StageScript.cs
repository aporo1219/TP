using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageScript : MonoBehaviour
{
    public int stage_num;
    public GameObject Stageone;
    public GameObject Stagetwo;
    public GameObject Stagethree;
    public GameObject Stagefour;
    public GameObject Stagefive;

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
            //�X�e�[�W2���o��
            Stagetwo.SetActive(true);
        }
        //�X�e�[�W2���N���A�����Ȃ�
        if (stage_num >= 2) 
        {
            //�X�e�[�W3���o��
            Stagethree.SetActive(true);
        }
        //�X�e�[�W3���N���A�����Ȃ�
        if (stage_num >= 3)
        {
            //�X�e�[�W4���o��
            Stagefour.SetActive(true);
        }
        //�X�e�[�W4���N���A�����Ȃ�
        if (stage_num >= 4)
        {
            //�X�e�[�W5���o��
            Stagefive.SetActive(true);
        }
    }
}
