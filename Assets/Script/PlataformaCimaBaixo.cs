using UnityEngine;
using System.Collections;

public class PlataformaCimaBaixo : MonoBehaviour {

	public float limiteCima;
	public float limiteBaixo;
	public float velocidade;

	void Start () {
	
	}
	
	void Update () {

		transform.Translate (0, velocidade, 0);

		if (transform.position.y > limiteCima || transform.position.y < limiteBaixo) {
			velocidade *= -1;
		}
	
	}
}
