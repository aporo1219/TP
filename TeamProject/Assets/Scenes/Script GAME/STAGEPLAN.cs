using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class STAGEPLAN : MonoBehaviour
{
    public GameObject SE;//�X�e�[�W�����̃e�L�X�g
    // Start is called before the first frame update
    void Start()
    {
        SE.SetActive(true);//�X�^�[�g�͕\��
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            SE.SetActive(false);//A�������������

        }
    } 
}