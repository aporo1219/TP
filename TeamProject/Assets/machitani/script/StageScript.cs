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
        //�X�e�[�W1���N���A�����Ȃ�
        if (stage_num >= 1) 
        {
            //�X�e�[�W2���o��
            ni.SetActive(true);
        }
        //�X�e�[�W2���N���A�����Ȃ�
        if (stage_num >= 2) 
        {
            //�X�e�[�W3���o��
            san.SetActive(true);
        }
        //�X�e�[�W3���N���A�����Ȃ�
        if (stage_num >= 3)
        {
            //�X�e�[�W4���o��
            yon.SetActive(true);
        }
        //�X�e�[�W4���N���A�����Ȃ�
        if (stage_num >= 4)
        {
            //�X�e�[�W5���o��
            go.SetActive(true);
        }
    }
}
