using UnityEngine;
using System.Collections;

public class PlataformaDireitaEsquerda : MonoBehaviour {

	public float limiteDireita;
	public float limiteEsquerda;
	public float velocidade;

	void Start () {
	
	}
	
	void Update () {

		transform.Translate (velocidade, 0, 0);

		if (transform.position.x > limiteDireita || transform.position.x < limiteEsquerda) {
			velocidade *= -1;
			Debug.Log ("asasas");
		}
	
	}
}
