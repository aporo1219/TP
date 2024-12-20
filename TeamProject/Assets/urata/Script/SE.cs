using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SE : MonoBehaviour
{
    public bool DontDestroyEnabled = true;
    // Start is called before the first frame update
    void Start()
    {
        if (DontDestroyEnabled)
        {
            // Scene��J�ڂ��Ă��I�u�W�F�N�g�������Ȃ��悤�ɂ���
            DontDestroyOnLoad(this);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GetComponent<AudioSource>().Play();
        }
        else if(Input.GetMouseButtonUp(0))
        {
            GetComponent<AudioSource>().Stop();
        }
    }
}
