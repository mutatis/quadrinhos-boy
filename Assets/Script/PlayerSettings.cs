using UnityEngine;
using System.Collections;

public class PlayerSettings : MonoBehaviour {
	
	public int jump = 250;
	private bool grounded = false;
	private int jumpnumb = 0;
	public int vidinha = 3;
	public int ponto = 0;

	[HideInInspector]
	public bool facingRight = true;
	public float maxSpeed = 5f;
	public float moveForce = 365f;
	public float posicaoAtual;
	public float posicaoY;
	bool segura;
	
	public static PlayerSettings instance;

	Animator animator;

	void Awake(){
		instance = this;	
	}

	void Start () 
	{
		animator = GetComponent<Animator> ();
	}
	
	void Update () {
		segura = GameObject.FindGameObjectWithTag("Teia").GetComponent<PlataformaTeia>().segura;

		if (segura == false) 
		{
			float h = Input.GetAxis ("Horizontal");

			posicaoY = transform.position.y;
			
			if (grounded == true) {
					Pulo ();
					jumpnumb += 1;
			}
			if (jumpnumb >= 2) {
				jumpnumb = 0;
				grounded = false;
			}
			
						/*if (h * rigidbody2D.velocity.x < maxSpeed) {
				rigidbody2D.AddForce (Vector2.right * h * moveForce);
					}*/
			
				transform.Translate ((h / 10), 0, 0);
			if(h > 0.03f || h < -0.03f)
			{
				animator.SetTrigger ("Player");
			}
			else
			{
				animator.SetTrigger ("parado");
			}
		}		
	}
	
	void Pulo (){
		rigidbody2D.AddForce(new Vector2(0f, jump));
	}
	
	void OnTriggerEnter2D(Collider2D collision){
		
		if (collision.gameObject.tag == "Fogo") {
			ponto += 1;
			Destroy(collision.gameObject);
		}
		if (collision.gameObject.tag == "Agua") {
			ponto += 1;
			Destroy(collision.gameObject);
		}
		if (collision.gameObject.tag == "Terra") {
			ponto += 1;
			Destroy(collision.gameObject);
		}
		if (collision.gameObject.tag == "Ar") {
			ponto += 1;
			Destroy(collision.gameObject);
		}
		if (collision.gameObject.tag == "Eter") {
			ponto += 1;
			Destroy(collision.gameObject);
		}
		if (collision.gameObject.tag == "Espinho") {
			vidinha -= 1;
		}
		
	}
	
	void OnCollisionEnter2D(Collision2D collision) {
		if (collision.gameObject.tag == "Plataforma") {
			grounded = true;
			posicaoAtual = transform.position.x;
			Debug.Log(posicaoAtual);
		}

		if (collision.gameObject.tag == "Teia") {
			grounded = true;
			posicaoAtual = transform.position.x;
			Debug.Log(posicaoAtual);
		}

		if (collision.gameObject.tag == "Finish") {
			Application.LoadLevel("Game_Over");
		}

		if (collision.gameObject.tag == "Camila") {
			Application.LoadLevel ("Apresentacao");
		}
	}
}