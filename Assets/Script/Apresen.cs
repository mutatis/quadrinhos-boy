using UnityEngine;
using System.Collections;

public class Apresen : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (0, -0.09f, 0);
	}

	void OnCollisionEnter2D(Collision2D collision) {

		if (collision.gameObject.tag == "Finish") {
			Application.LoadLevel("1Frase");
		}
	}
}
