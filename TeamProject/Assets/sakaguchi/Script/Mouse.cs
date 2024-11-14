using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Mouse : MonoBehaviour
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
        if (SceneManager.GetActiveScene().name == "Title1")
        {
            Cursor.visible = true;//カーソル表示
            Cursor.lockState = CursorLockMode.None;//カーソル機能あり
            ClickGN(number0);
        }
        if (SceneManager.GetActiveScene().name == "GameOver")
        {
            Cursor.visible = true;//カーソル表示
            Cursor.lockState = CursorLockMode.None;//カーソル機能あり
            ClickGO(number);
        }
        if (SceneManager.GetActiveScene().name == "GameClear")
        {
            Cursor.visible = true;//カーソル表示
            Cursor.lockState = CursorLockMode.None;//カーソル機能あり
            ClickGC(number1);
        }
        if (SceneManager.GetActiveScene().name == "RANKING1")
        {

            ClickB(number2);
        }
    }

    public void ClickGN(int N0)
    {
        switch (N0)
        {
            case 1:
                SceneManager.LoadScene("Unity");
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
                SceneManager.LoadScene("Unity");
                break;
            case 2:
                SceneManager.LoadScene("Title1");
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
                SceneManager.LoadScene("Title1");
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
                SceneManager.LoadScene("GameClear");
                break;
            default:
                break;
        }
    }
}



