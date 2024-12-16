using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialChange : MonoBehaviour
{
    public void change_button()
    {
        //チュートリアル画面に移動
        SceneManager.LoadScene("operation");
    }
}
