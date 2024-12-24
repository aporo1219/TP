using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearkMove1 : MonoBehaviour
{
    private Vector3 direction;//目的地の変数
    private float speed;//店員の速さの変数
    public float onestep;//一歩の変数
    // Start is called before the first frame update
    void Start()
    {
        //初期化
        Vector3 direction = new Vector3((float)0.8, (float)-3.09, 0);//店員の目的地の設定
        speed = 0.5f;//店員のスピード
        onestep = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        onestep = speed * Time.deltaTime;//１秒間に進む距離
        transform.position = Vector3.MoveTowards(transform.position, direction, onestep);//目的地まで一定の
    }
}
