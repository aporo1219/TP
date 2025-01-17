using UnityEngine;

public class StartParticle : MonoBehaviour
{
	[SerializeField]
	[Tooltip("発生させるエフェクト(パーティクル)")]
	private ParticleSystem particle;

	//衝突時の処理
	private void OnTriggerEnter2D(Collider2D other)
	{
		// 当たったアイテムが"chocolate"“cookie”“pudding”"Choco night"“Pud night”"Cook night"　"Cook night"タグを持っていたら
		if (other.gameObject.tag == "chocolate" || other.gameObject.tag == "Choco night")//チョコ
		{
			ParticleSystem();
		}
		else if (other.gameObject.tag == "cookie" || other.gameObject.tag == "Cook night")//クッキー
		{
			ParticleSystem();
		}
		else if (other.gameObject.tag == "pudding" || other.gameObject.tag == "Pud night")//プリン
		{
			ParticleSystem();
		}

		void ParticleSystem()
        {
			// パーティクルシステムのインスタンスを生成する。
			ParticleSystem newParticle = Instantiate(particle);
			// パーティクルの発生場所をこのスクリプトをアタッチしているGameObjectの場所にする。
			newParticle.transform.position = this.transform.position;
			// パーティクルを発生させる。
			newParticle.Play();
			// インスタンス化したパーティクルシステムのGameObjectを5秒後に削除する。(任意)
			// ※第一引数をnewParticleだけにするとコンポーネントしか削除されない。
			Destroy(newParticle.gameObject, 5.0f);

			//SE再生
			SoundManager.soundManager.SEPlay(SEType.recovery);
		}
	}
}