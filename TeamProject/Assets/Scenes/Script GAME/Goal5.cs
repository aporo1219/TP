using UnityEngine;
using UnityEngine.SceneManagement;

// ゴールを制御するスクリプト
public class Goal5 : MonoBehaviour
{
    // ゴールしたかどうか
    private bool m_isGoal;

    // 他のオブジェクトと当たった時に呼び出される関数
    private void OnTriggerEnter2D(Collider2D other)
    {
        // まだゴールしておらず
        if (!m_isGoal)
        {
            // 名前に「Player」が含まれるオブジェクトと当たったら
            if (other.name.Contains("Player"))
            {
                SceneManager.LoadScene("GAMECLEAR1");
            }
        }
    }
}