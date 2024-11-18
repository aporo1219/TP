using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackMoveVertical : MonoBehaviour
{
    public float speed = 0;//スクロールするスピードの変数
   

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0, Time.deltaTime * speed);//下に絵を動かす

        if(transform.position.y <= -11)//絵が下まで行ったら上に戻る
        {
            transform.position = new Vector3(0, 5.22f);
        }
    }
}
