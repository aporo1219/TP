using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageGoalScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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

