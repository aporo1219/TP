using UnityEngine;
using UnityEngine.SceneManagement;

// �S�[���𐧌䂷��X�N���v�g
public class Goal1 : MonoBehaviour
{
    private int GoalScore;

    public void Start()
    {
        GoalScore = PlayerPrefs.GetInt("SCORE", GoalScore);//�X�R�A�����擾����
    }

    public void Update()
    {
        //�X�e�[�W1���N���A������
        if (CalorieTEXT.StageInfor == 0)
        {
            //�S�[���X�R�A��0�Ȃ�
            if (GoalScore == 0) 
            {
                //�S�[���X�R�A+1
                GoalScore += 1;
                //�S�[���X�R�A�̒l��SCORE�ɓ����
                PlayerPrefs.SetInt("SCORE", GoalScore);
                //PlayerPrefs���Z�[�u����
                PlayerPrefs.Save();
            }
        }
        //�X�e�[�W2���N���A������
        if (CalorieTEXT.StageInfor == 1)
        {
            if (GoalScore == 1)
            {
                //�S�[���X�R�A+1
                GoalScore += 1;
                //�S�[���X�R�A�̒l��SCORE�ɓ����
                PlayerPrefs.SetInt("SCORE", GoalScore);
                //PlayerPrefs���Z�[�u����
                PlayerPrefs.Save();
            }
        }
        //�X�e�[�W3���N���A������
        if (CalorieTEXT.StageInfor == 2)
        {
            if (GoalScore == 2)
            {
                //�S�[���X�R�A+1
                GoalScore += 1;
                //�S�[���X�R�A�̒l��SCORE�ɓ����
                PlayerPrefs.SetInt("SCORE", GoalScore);
                //PlayerPrefs���Z�[�u����
                PlayerPrefs.Save();
            }
        }
        //�X�e�[�W4���N���A������
        if (CalorieTEXT.StageInfor == 3)
        {
            if (GoalScore == 3)
            {
                //�S�[���X�R�A+1
                GoalScore += 1;
                //�S�[���X�R�A�̒l��SCORE�ɓ����
                PlayerPrefs.SetInt("SCORE", GoalScore);
                //PlayerPrefs���Z�[�u����
                PlayerPrefs.Save();
            }
        }
        //�X�e�[�W5���N���A������
        if (CalorieTEXT.StageInfor == 4)
        {
            if (GoalScore == 4)
            {
                //�S�[���X�R�A+1
                GoalScore += 1;
                //�S�[���X�R�A�̒l��SCORE�ɓ����
                PlayerPrefs.SetInt("SCORE", GoalScore);
                //PlayerPrefs���Z�[�u����
                PlayerPrefs.Save();
            }
        }
    }

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
                //�Q�[���I�[�o�[�V�[���ړ�
                SceneManager.LoadScene("GAMECLEAR1");
            }
        }
    }
}