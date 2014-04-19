using UnityEngine;
using System.Collections;

public class Andando : MonoBehaviour {
	
	
	[HideInInspector]
	public bool facingRight = true;
	private bool virou1 = false;
	private bool virou2 = true;
	bool ani;
	
	
	void Update () {
		
		ani = GameObject.FindGameObjectWithTag("Parado").GetComponent<Parado>().animacao;
		
		if (ani == true) {
			renderer.enabled = true;
		}
		else if (ani == false) {
			renderer.enabled = false;
		}
		
		if ((Input.GetKeyDown (KeyCode.RightArrow) || Input.GetKeyDown (KeyCode.D)) && virou1 == true) {
			Flip ();
			virou1 = false;
			virou2 = true;
		}
		
		else if ((Input.GetKeyDown (KeyCode.LeftArrow) || Input.GetKeyDown (KeyCode.A)) && virou2 == true) {
			Flip ();
			virou2 = false;
			virou1 = true;
		}
	}
	
	void Flip () {
		
		facingRight = !facingRight;
		
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}