using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // ��Q���ɂԂ��������ǂ������m�F
        if (other.CompareTag("Player"))
        {
            //�Q�[���I�u�W�F�N�g��j��
            Destroy(gameObject);
        }
    }
}
