using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageGoalScript : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            //PlayerPrefs��SCORE��3�Ƃ����l������
            PlayerPrefs.SetInt("SCORE", 1);
            //PlayerPrefs���Z�[�u����         
            PlayerPrefs.Save();

        }
    }
}

