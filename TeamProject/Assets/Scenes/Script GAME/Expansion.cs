using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Expansion : MonoBehaviour
{
    public GameObject Dumbbel;
    public float TimerS = 0.0f;//��莞�Ԓ�����ƈړ����Ȃ�����ϐ�
    private Transform movement;//�ړ��̕ϐ�

    // Start is called before the first frame update
    void Start()
    { 
        Dumbbel.transform.localScale += new Vector3((float)0.0, (float)0.0, 1);
    }

    // Update is called once per frame
    void Update()
    {
        //�ړ����Ȃ����邽�߂̏���
        TimerS += Time.deltaTime;
        if (TimerS != 30.0)
        {
            //�Q�[���I�u�W�F�N�g�̌��݂̍��W�ʒu����
            movement = gameObject.transform;
            //1�b�Ԃɂ�����ړ����邩�̏���
            transform.position += new Vector3(-3, 0) * Time.deltaTime;
            for (float i = 0;i< 25;i+=0.01f)
            {
            Dumbbel.transform.localScale += new Vector3((float)i, (float)i, 1);
            }
        }
    }
       
}
