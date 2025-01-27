using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Calorie : MonoBehaviour
{
    public Slider calobar;
    public int calo = 100;
    private float currentTime = 0f;
    // Start is called before the first frame update
    void Start()
    {
        calobar = GameObject.Find("calobar").GetComponent<Slider>();
        calobar.maxValue = calo;

        //カロリーゲージの初期値が100
        calobar.value = 100;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;

        if(currentTime >=1.0f)
        {
            //カロリーゲージが2ずつ減っていく
            calobar.value -= 2;
            currentTime = 0;
        }
        /*if (calobar.value == 0)
        {
            //ゲームオーバー画面に移動
            SceneManager.LoadScene("GAMEOVER1");
        }*/
    }
}
