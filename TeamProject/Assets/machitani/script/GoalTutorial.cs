using UnityEngine;
using UnityEngine.SceneManagement;

// �S�[���𐧌䂷��X�N���v�g
public class GoalTutorial : MonoBehaviour
{
    // �S�[���������ǂ���
    private bool m_isGoal;

    // ���̃I�u�W�F�N�g�Ɠ����������ɌĂяo�����֐�
    private void OnTriggerEnter2D(Collider2D other)
    {
        // �܂��S�[�����Ă��炸
        if (!m_isGoal)
        {
            // ���O�ɁuPlayer�v���܂܂��I�u�W�F�N�g�Ɠ���������
            if (other.name.Contains("Player"))
            {
                //�Q�[���N���A�V�[���Ɉړ�
                SceneManager.LoadScene("GAMECLEAR1");
                //PlayerPrefs��SCORE��3�Ƃ����l������
                PlayerPrefs.SetInt("SCORE", 0);
                //PlayerPrefs���Z�[�u����         
                PlayerPrefs.Save();
            }
        }
    }
}