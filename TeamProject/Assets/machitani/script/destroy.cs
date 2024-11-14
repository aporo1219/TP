using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    public float time = 4;

    // DestoryしたいGameObject(基本はアタッチされたもの)
    public GameObject gameObject;

    // Use this for initialization
    void Start()
    {
        // Destory
        Destroy(gameObject, time);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
