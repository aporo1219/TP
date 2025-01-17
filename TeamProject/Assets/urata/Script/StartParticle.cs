using UnityEngine;

public class StartParticle : MonoBehaviour
{
	[SerializeField]
	[Tooltip("����������G�t�F�N�g(�p�[�e�B�N��)")]
	private ParticleSystem particle;

	//�Փˎ��̏���
	private void OnTriggerEnter2D(Collider2D other)
	{
		// ���������A�C�e����"chocolate"�gcookie�h�gpudding�h"Choco night"�gPud night�h"Cook night"�@"Cook night"�^�O�������Ă�����
		if (other.gameObject.tag == "chocolate" || other.gameObject.tag == "Choco night")//�`���R
		{
			ParticleSystem();
		}
		else if (other.gameObject.tag == "cookie" || other.gameObject.tag == "Cook night")//�N�b�L�[
		{
			ParticleSystem();
		}
		else if (other.gameObject.tag == "pudding" || other.gameObject.tag == "Pud night")//�v����
		{
			ParticleSystem();
		}

		void ParticleSystem()
        {
			// �p�[�e�B�N���V�X�e���̃C���X�^���X�𐶐�����B
			ParticleSystem newParticle = Instantiate(particle);
			// �p�[�e�B�N���̔����ꏊ�����̃X�N���v�g���A�^�b�`���Ă���GameObject�̏ꏊ�ɂ���B
			newParticle.transform.position = this.transform.position;
			// �p�[�e�B�N���𔭐�������B
			newParticle.Play();
			// �C���X�^���X�������p�[�e�B�N���V�X�e����GameObject��5�b��ɍ폜����B(�C��)
			// ����������newParticle�����ɂ���ƃR���|�[�l���g�����폜����Ȃ��B
			Destroy(newParticle.gameObject, 5.0f);

			//SE�Đ�
			SoundManager.soundManager.SEPlay(SEType.recovery);
		}
	}
}