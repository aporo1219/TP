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
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;//カーソル非表示
        Cursor.lockState = CursorLockMode.None;//カーソル機能なし
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "STAGE1")
        {
            Cursor.visible = false;//カーソル表示
            Cursor.lockState = CursorLockMode.Locked;//カーソル機能あり
            ClickGN(number0);
        }
        if (SceneManager.GetActiveScene().name == "Title")
        {
            
            ClickGN(number0);
        }
        if (SceneManager.GetActiveScene().name == "GAMEOVER1")
        {
            
            ClickGO(number);
        }
        if (SceneManager.GetActiveScene().name == "GAMECLEAR1")
        {
           
            ClickGC(number1);
        }
    }

    public void ClickGN (int N0)
    {
        switch (N0)
        {
            case 1:
                SceneManager.LoadScene("STAGE1");
                break;
      
            default:
                break;
        }
    }
    public void ClickGO(int N)
    {
       switch(N)
        {
            case 1:
                SceneManager.LoadScene("STAGE1");
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
   

   
