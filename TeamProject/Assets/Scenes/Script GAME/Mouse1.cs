using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Mouse1 : MonoBehaviour
{
    private int number0;
    private int number;
    private int number1;
    private int number2;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;//カーソル非表示
        Cursor.lockState = CursorLockMode.Locked;//カーソル機能なし
    }

    // Update is called once per frame
    void Update()
    {
        
        if (SceneManager.GetActiveScene().name == "Title")
        {
            Cursor.visible = true;//カーソル表示
            Cursor.lockState = CursorLockMode.None;//カーソル機能あり
            ClickGN(number0);
        }
        if (SceneManager.GetActiveScene().name == "GAMEOVER1")
        {
            Cursor.visible = true;//カーソル表示
            Cursor.lockState = CursorLockMode.None;//カーソル機能あり
            ClickGO(number);
        }
        if (SceneManager.GetActiveScene().name == "GAMECLEAR1")
        {
            Cursor.visible = true;//カーソル表示
            Cursor.lockState = CursorLockMode.None;//カーソル機能あり
            ClickGC(number1);
        }
        if (SceneManager.GetActiveScene().name == "RANKING")
        {
            Cursor.visible = true;//カーソル表示
            Cursor.lockState = CursorLockMode.None;//カーソル機能あり
            ClickB(number2);
        }
    }

    public void ClickGN(int N0)
    {
        switch (N0)
        {
            case 1:
                SceneManager.LoadScene("game select");
                break;

            default:
                break;
        }
    }
    public void ClickGO(int N)
    {
        switch (N)
        {
            case 1:
                if(CalorieTEXT.StageInfor == 0)
                {
                  SceneManager.LoadScene("STAGE1");
                }
                if (CalorieTEXT.StageInfor == 1)
                {
                    SceneManager.LoadScene("STAGE2");
                }
                if (CalorieTEXT.StageInfor == 2)
                {
                    SceneManager.LoadScene("STAGE3");
                }
                if (CalorieTEXT.StageInfor == 3)
                {
                    SceneManager.LoadScene("STAGE4");
                }
                if (CalorieTEXT.StageInfor == 4)
                {
                    SceneManager.LoadScene("STAGE5");
                }
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
                SceneManager.LoadScene("game select");
                break;
            case 2:
                SceneManager.LoadScene("Title");
                break;
            case 3:
                SceneManager.LoadScene("RANKING");
                break;
            default:
                break;
        }
    }

    public void ClickB(int N2)
    {
        switch (N2)
        {
            case 1:
                SceneManager.LoadScene("GAMECLEAR1");
                break;
            default:
                break;
        }
    }
}



