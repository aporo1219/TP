using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialChange : MonoBehaviour
{
    public void change_button()
    {
        //�`���[�g���A����ʂɈړ�
        SceneManager.LoadScene("operation");
    }
}
