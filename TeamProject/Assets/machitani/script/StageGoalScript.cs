using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageGoalScript : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            //PlayerPrefsのSCOREに3という値を入れる
            PlayerPrefs.SetInt("SCORE", 1);
            //PlayerPrefsをセーブする         
            PlayerPrefs.Save();

        }
    }
}

