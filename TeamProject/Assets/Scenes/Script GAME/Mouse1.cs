using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Mouse1 : MonoBehaviour
{
    private int number_TITLE;//タイトルのボタン用の引数
    private int number_GAMEOVER;//ゲームオーバーのボタン用の引数
    private int number_GAMECLEAR;//ゲームクリアのボタン用の引数
    private int number_RANKING;//ランキングのボタン用の引数
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;//カーソル非表示
        Cursor.lockState = CursorLockMode.Locked;//カーソル機能なし
    }

    // Update is called once per frame
    void Update()
    {
        //シーンがタイトルの時
        if (SceneManager.GetActiveScene().name == "Title")
        {
            Cursor.visible = true;//カーソル表示
            Cursor.lockState = CursorLockMode.None;//カーソル機能あり
            ClickGN(number_TITLE);
        }
        //シーンがゲームオーバーの時
        if (SceneManager.GetActiveScene().name == "GAMEOVER1")
        {
            Cursor.visible = true;//カーソル表示
            Cursor.lockState = CursorLockMode.None;//カーソル機能あり
            ClickGO(number_GAMEOVER);
        }
        //シーンがゲームクリアの時
        if (SceneManager.GetActiveScene().name == "GAMECLEAR1")
        {
            Cursor.visible = true;//カーソル表示
            Cursor.lockState = CursorLockMode.None;//カーソル機能あり
            ClickGC(number_GAMECLEAR);
        }
        //シーンがランキングの時
        if (SceneManager.GetActiveScene().name == "RANKING")
        {
            Cursor.visible = true;//カーソル表示
            Cursor.lockState = CursorLockMode.None;//カーソル機能あり
            ClickB(number_RANKING);
        }
    }

    //タイトルのボタン関数
    public void ClickGN(int TITLE_BUTTON)
    {
        switch (TITLE_BUTTON)
        {
            case 1:
                //ゲームセレクトへボタンの処理
                SceneManager.LoadScene("game select");
                break;

            default:
                break;
        }
    }
    //ゲームオーバーシーンのボタン関数
    public void ClickGO(int OVER_BUTTON)
    {
        switch (OVER_BUTTON)
        {
            case 1:
                //戻るボタンの処理
                //失敗したステージに戻るためステージ情報を取得し、分けている
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
                //タイトルに戻るボタンの処理
                SceneManager.LoadScene("Title");
                break;
            default:
                break;
        }
    }
    //ゲームクリアのボタン関数
    public void ClickGC(int CLEAR_BUTTON)
    {
        switch (CLEAR_BUTTON)
        {
            case 1:
                //ステージセレクトへのボタンの処理
                SceneManager.LoadScene("game select");
                break;
            case 2:
                //タイトルに戻るボタンの処理
                SceneManager.LoadScene("Title");
                break;
            case 3:
                //ランキング表示ボタンの処理
                SceneManager.LoadScene("RANKING");
                break;
            default:
                break;
        }
    }
    //ランキングシーンのボタン関数
    public void ClickB(int RANKING_BUTTON)
    {
        switch (RANKING_BUTTON)
        {
            case 1:
                //ゲームクリアに戻るボタンの処理
                SceneManager.LoadScene("GAMECLEAR1");
                break;
            default:
                break;
        }
    }
}



