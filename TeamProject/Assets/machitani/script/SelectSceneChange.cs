using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectSceneChange : MonoBehaviour
{
    public void change_button()
    {
        //ゲームセレクト画面に移動
        SceneManager.LoadScene("game select");
    }
}
