using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearkMove1 : MonoBehaviour
{
    private Vector3 direction;//�ړI�n�̕ϐ�
    private float speed;//�X���̑����̕ϐ�
    public float onestep;//����̕ϐ�
    // Start is called before the first frame update
    void Start()
    {
        //������
        Vector3 direction = new Vector3((float)0.8, (float)-3.09, 0);//�X���̖ړI�n�̐ݒ�
        speed = 0.5f;//�X���̃X�s�[�h
        onestep = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        onestep = speed * Time.deltaTime;//�P�b�Ԃɐi�ދ���
        transform.position = Vector3.MoveTowards(transform.position, direction, onestep);//�ړI�n�܂ň���
    }
}
