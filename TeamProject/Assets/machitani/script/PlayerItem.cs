using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerItem : MonoBehaviour
{
    public Slider calobar;

    void OnTriggerEnter2D(Collider2D collision)
    {
        //夜のチョコに当たったら
        if (collision.gameObject.tag == "Choco night")
        {
            //カロリーゲージを10増やす
            calobar.value += 10;
        }
        //夜のプリンに当たったら
        if (collision.gameObject.tag == "Pud night")
        {
            //カロリーゲージを15増やす
            calobar.value += 15;
        }
        //夜のクッキーに当たったら
        if (collision.gameObject.tag == "Cook night")
        {
            //カロリーゲージを５増やす
            calobar.value += 5;
        }
        //落とし穴に当たったら
        if (collision.gameObject.tag == "pitfall")
        {
            //カロリーゲージを20減らす
            calobar.value -= 20;
        }
        //唐辛子に当たったら
        if (collision.gameObject.tag == "chili pepper")
        {
            //カロリーゲージを10減らす
            calobar.value -= 10;
        }
        //チョコレートに当たったら
        if (collision.gameObject.tag == "chocolate")
        {
            //カロリーゲージを20増やす
            calobar.value += 20;
        }
        //クッキーに当たったら
        if (collision.gameObject.tag == "cookie")
        {
            //カロリーゲージを10増やす
            calobar.value += 10;
        }
        //ダンベルに当たったら
        if (collision.gameObject.tag == "dumbbell")
        {
            //カロリーゲージを30減らす
            calobar.value -= 30;
        }
        //プリンに当たったら
        if (collision.gameObject.tag == "pudding")
        {
            //カロリーゲージを30増やす
            calobar.value += 30;
        }
    }
}