using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class explanation : MonoBehaviour
{
    public Text textUI;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("aiu", 4);
    }

    void aiu()
    {
        textUI.text = " ";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
