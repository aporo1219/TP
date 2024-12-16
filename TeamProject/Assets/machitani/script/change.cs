using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class change : MonoBehaviour
{
    public void change_button()
    {
        //タイトルシーンに移動
        SceneManager.LoadScene("Title");
    }
}
