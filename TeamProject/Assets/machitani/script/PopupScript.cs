using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupScript : MonoBehaviour
{
    public GameObject Popup;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Appear()
    {
        Popup.SetActive(true);
    }

    public void Delete()
    {
        Popup.SetActive(false);
    }
}
