using UnityEngine;
using UnityEngine.SceneManagement;

// �S�[���𐧌䂷��X�N���v�g
public class GoalTutorial : MonoBehaviour
{
    // ���̃I�u�W�F�N�g�Ɠ����������ɌĂяo�����֐�
     void OnTriggerEnter2D(Collider2D collision)
    {
            // ���O�ɁuPlayer�v���܂܂��I�u�W�F�N�g�Ɠ���������
            if (collision.gameObject.tag == "Player")
            {
            SceneManager.LoadScene("TutorialClear");
                //PlayerPrefs��SCORE��0�Ƃ����l������
                PlayerPrefs.SetInt("SCORE", 0);
                //PlayerPrefs���Z�[�u����         
                PlayerPrefs.Save();

            }
    }
}