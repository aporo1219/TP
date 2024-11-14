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
        if (stage_num >= 2) 
        {
            ni.SetActive(true);
        }
        if (stage_num >= 3) 
        {
            san.SetActive(true);
        }
        if (stage_num >= 4)
        {
            yon.SetActive(true);
        }
        if (stage_num >= 5)
        {
            go.SetActive(true);
        }
    }
}
