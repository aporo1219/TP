using UnityEngine;
using UnityEngine.SceneManagement;

// �S�[���𐧌䂷��X�N���v�g
public class Goal5 : MonoBehaviour
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
                SceneManager.LoadScene("GAMECLEAR1");
            }
        }
    }
}