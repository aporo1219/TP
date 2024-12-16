using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // 障害物にぶつかったかどうかを確認
        if (other.CompareTag("Player"))
        {
            //ゲームオブジェクトを破壊
            Destroy(gameObject);
        }
    }
}
