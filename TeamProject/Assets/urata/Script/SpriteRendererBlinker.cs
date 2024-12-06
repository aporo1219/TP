using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteRendererBlinker : MonoBehaviour
{
    //移動スピードと点滅の間隔
    [SerializeField] float flashInterval;
    //点滅させるときのループカウント
    [SerializeField] int loopCount;
    //点滅させるためのSpriteRenderer
    SpriteRenderer sp;
    //コライダーをオンオフするためのBoxCollider2D
    BoxCollider2D bc2d;
    //当たったかどうかのフラグ
    bool isHit;

    //障害物
    public GameObject chilipepper;//唐辛子
    public GameObject dumbbell;//ダンベル
    public GameObject pitfall;//落とし穴
    public GameObject emptyca;//空き缶

    private void Start()
    {
        //SpriteRenderer格納
        sp = GetComponent<SpriteRenderer>();
        //BoxCollider2D格納
        bc2d = GetComponent<BoxCollider2D>();
    }

    //衝突時の処理
    private void OnTriggerEnter2D(Collider2D col)
    {
        //落とし穴
        if (col.gameObject.tag == "pitfall")
        {
            //コルーチンを開始
            StartCoroutine(_hit());
        }
        return;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        //唐辛子
        if (other.gameObject.tag == "chili pepper")
        {
            //コルーチンを開始
            StartCoroutine(_hit());
        }

        //ダンベル
        if (other.gameObject.tag == "dumbbell")
        {
            //コルーチンを開始
            StartCoroutine(_hit());
        }

        //空き缶
        if (other.gameObject.tag == "empty ca")
        {
            //コルーチンを開始
            StartCoroutine(_hit());
        }
        return;
    }
    //点滅させる処理
    IEnumerator _hit()
    {
        //当たりフラグをtrueに変更（当たっている状態）
        isHit = true;

        //点滅ループ開始
        for (int i = 0; i < loopCount; i++)
        {
            //flashInterval待ってから
            yield return new WaitForSeconds(flashInterval);
            //spriteRendererをオフ
            sp.enabled = false;

            //flashInterval待ってから
            yield return new WaitForSeconds(flashInterval);
            //spriteRendererをオン
            sp.enabled = true;
            //SE再生
            SoundManager.soundManager.SEPlay(SEType.damage);
        }
        //点滅ループが抜けたら当たりフラグをfalse(当たってない状態)
        isHit = false;
    }
}