using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectSceneChange : MonoBehaviour
{
    public void change_button()
    {
        //�Q�[���Z���N�g��ʂɈړ�
        SceneManager.LoadScene("game select");
    }
}
