using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Mouse : MonoBehaviour
{
    private int number;
    private int number1;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;//�J�[�\����\��
        Cursor.lockState = CursorLockMode.Locked;//�J�[�\���@�\�Ȃ�
    }

    // Update is called once per frame
    void Update()
    {
         
        if (SceneManager.GetActiveScene().name == "GameOver")
        {
            Cursor.visible = true;//�J�[�\���\��
            Cursor.lockState = CursorLockMode.None;//�J�[�\���@�\����
            ClickGO(number);
        }
        if (SceneManager.GetActiveScene().name == "GameOver")
        {
            Cursor.visible = true;//�J�[�\���\��
            Cursor.lockState = CursorLockMode.None;//�J�[�\���@�\����
            ClickGC(number1);
        }
    }

    public void ClickGO(int N)
    {
       switch(N)
        {
            case 1:
                SceneManager.LoadScene("Unity");
                break;
            case 2:
                SceneManager.LoadScene("Title");
                break;
            default:
                break;
        }
    }
    public void ClickGC(int N1)
    {
        switch (N1)
        {
            case 1:
                SceneManager.LoadScene("StageChoicee");
                break;
            case 2:
                SceneManager.LoadScene("Title");
                break;
            default:
                break;
        }
    }
}
   

   