using UnityEngine;
using System.Collections;

public class Pe : MonoBehaviour {
	

	public bool peGrounded = false;

	void Start () {
	}
	
	void Update () {
	
		/*if (jumpnumb >= 2) {
			jumpnumb = 0;
			peGrounded = false;
		}*/

	}

	void OnCollisionEnter2D(Collision2D collision) {
		if (collision.gameObject.tag == "Plataforma") {
			peGrounded = true;
			Debug.Log("aaaaaaaaaaa");
		}
	}
}