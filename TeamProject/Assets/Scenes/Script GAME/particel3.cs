using UnityEngine;

public class particel3: MonoBehaviour
{
	[SerializeField]
	[Tooltip("発生させるエフェクト(パーティクル)")]
	private ParticleSystem particle;

	//衝突時の処理
	private void OnCollisionEnter2D(Collision2D collision)
	{
		// 当たった相アイテムが"chocolate"“cookie”“pudding”タグを持っていたら
		if (collision.gameObject.tag == "chocolate")//チョコ
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
		}

		if (collision.gameObject.tag == "cookie")//クッキー
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
		}

		if (collision.gameObject.tag == "pudding")//プリン
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
		}

		if (collision.gameObject.tag == "Pud night")//プリン 夜
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
		}

		if (collision.gameObject.tag == "Choco night")//チョコ　夜
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
		}

		if (collision.gameObject.tag == "Cook night")//クッキー　夜
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
		}
	}
}