using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupScript : MonoBehaviour
{
    public GameObject Popup;

    public void Appear()
    {
        //�|�b�v�A�b�v���o��
        Popup.SetActive(true);
    }

    public void Delete()
    {
        //�|�b�v�A�b�v������
        Popup.SetActive(false);
    }
}
