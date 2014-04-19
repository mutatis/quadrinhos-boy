using UnityEngine;
using System.Collections;

public class VirarAcelerometro : MonoBehaviour {
	
	[HideInInspector]
	public bool facingRight = true;
	private bool virou1 = false;
	private bool virou2 = true;
	float posicao;
	
	void Update () {
		posicao = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerSettings>().posicaoAtual;

		if ((transform.position.x > posicao) && virou1 == true) {
			Flip ();
			virou1 = false;
			virou2 = true;
		}
		
		if ((transform.position.x < posicao) && virou2 == true) {
			Flip ();
			virou2 = false;
			virou1 = true;
		}
	}

	/*void OnCollisionEnter2D(Collision2D collision) {
		if (collision.gameObject.tag == "Plataforma") {
			posicaoAtual = transform.position.x;
		}
	}*/
	
	void Flip () {
		
		facingRight = !facingRight;
		
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}