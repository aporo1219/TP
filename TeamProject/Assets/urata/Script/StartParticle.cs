using UnityEngine;

public class StartParticle : MonoBehaviour
{
	[SerializeField]
	[Tooltip("����������G�t�F�N�g(�p�[�e�B�N��)")]
	private ParticleSystem particle;

	//�Փˎ��̏���
	private void OnCollisionEnter2D(Collision2D collision)
	{
		// ���������A�C�e����"chocolate"�gcookie�h�gpudding�h�^�O�������Ă�����
		if (collision.gameObject.tag == "chocolate")//�`���R
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

		if (collision.gameObject.tag == "cookie")//�N�b�L�[
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

		if (collision.gameObject.tag == "pudding")//�v����
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
		// ���������A�C�e����"Choco night"�gPud night�h�^�O�������Ă�����
		if (collision.gameObject.tag == "Choco night")//�`���R
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

		if (collision.gameObject.tag == "Pud night")//�v����
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