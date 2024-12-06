using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class STAGEPLAN : MonoBehaviour
{
    public GameObject SE;//ステージ説明のテキスト
    public GameObject SEBack;//ステージ説明の背景
    // Start is called before the first frame update
    void Start()
    {
        SE.SetActive(true);//スタートは表示
        SEBack.SetActive(true);//スタートは表示
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            SE.SetActive(false);//Aを押したら消す
            SEBack.SetActive(false);//Aを押したら消す
        }
    } 
}
