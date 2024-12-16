using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupScript : MonoBehaviour
{
    public GameObject Popup;

    public void Appear()
    {
        //ポップアップを出す
        Popup.SetActive(true);
    }

    public void Delete()
    {
        //ポップアップを消す
        Popup.SetActive(false);
    }
}
