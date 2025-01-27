using UnityEngine;
using UnityEngine.SceneManagement;

// ゴールを制御するスクリプト
public class GoalTutorial : MonoBehaviour
{
    // 他のオブジェクトと当たった時に呼び出される関数
     void OnTriggerEnter2D(Collider2D collision)
    {
            // 名前に「Player」が含まれるオブジェクトと当たったら
            if (collision.gameObject.tag == "Player")
            {
            SceneManager.LoadScene("TutorialClear");
                //PlayerPrefsのSCOREに0という値を入れる
                PlayerPrefs.SetInt("SCORE", 0);
                //PlayerPrefsをセーブする         
                PlayerPrefs.Save();

            }
    }
}