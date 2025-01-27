using UnityEngine;
using UnityEngine.SceneManagement;

// ゴールを制御するスクリプト
public class Goal1 : MonoBehaviour
{
    private int GoalScore;

    public void Start()
    {
        GoalScore = PlayerPrefs.GetInt("SCORE", GoalScore);//スコア情報を取得する
    }

    public void Update()
    {
        //ステージ1をクリアしたら
        if (CalorieTEXT.StageInfor == 0)
        {
            //ゴールスコアが0なら
            if (GoalScore == 0) 
            {
                //ゴールスコア+1
                GoalScore += 1;
                //ゴールスコアの値をSCOREに入れる
                PlayerPrefs.SetInt("SCORE", GoalScore);
                //PlayerPrefsをセーブする
                PlayerPrefs.Save();
            }
        }
        //ステージ2をクリアしたら
        if (CalorieTEXT.StageInfor == 1)
        {
            if (GoalScore == 1)
            {
                //ゴールスコア+1
                GoalScore += 1;
                //ゴールスコアの値をSCOREに入れる
                PlayerPrefs.SetInt("SCORE", GoalScore);
                //PlayerPrefsをセーブする
                PlayerPrefs.Save();
            }
        }
        //ステージ3をクリアしたら
        if (CalorieTEXT.StageInfor == 2)
        {
            if (GoalScore == 2)
            {
                //ゴールスコア+1
                GoalScore += 1;
                //ゴールスコアの値をSCOREに入れる
                PlayerPrefs.SetInt("SCORE", GoalScore);
                //PlayerPrefsをセーブする
                PlayerPrefs.Save();
            }
        }
        //ステージ4をクリアしたら
        if (CalorieTEXT.StageInfor == 3)
        {
            if (GoalScore == 3)
            {
                //ゴールスコア+1
                GoalScore += 1;
                //ゴールスコアの値をSCOREに入れる
                PlayerPrefs.SetInt("SCORE", GoalScore);
                //PlayerPrefsをセーブする
                PlayerPrefs.Save();
            }
        }
        //ステージ5をクリアしたら
        if (CalorieTEXT.StageInfor == 4)
        {
            if (GoalScore == 4)
            {
                //ゴールスコア+1
                GoalScore += 1;
                //ゴールスコアの値をSCOREに入れる
                PlayerPrefs.SetInt("SCORE", GoalScore);
                //PlayerPrefsをセーブする
                PlayerPrefs.Save();
            }
        }
    }

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
                //ゲームオーバーシーン移動
                SceneManager.LoadScene("GAMECLEAR1");
            }
        }
    }
}