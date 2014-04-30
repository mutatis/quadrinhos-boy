using UnityEngine;
using System.Collections;

public class Inimigo : MonoBehaviour {

	float limiteDireita = 35;
	float limiteEsquerda = 6;
	public float velocidade;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.Translate (velocidade, 0, 0);
		
		if (transform.position.x > limiteDireita || transform.position.x < limiteEsquerda) {
			velocidade *= -1;
			Vector3 theScale = transform.localScale;
			theScale.x *= -1;
			transform.localScale = theScale;
		}
	}

	void OnMouseDown()
	{
		Destroy (gameObject);
	}
}
