using UnityEngine;
using System.Collections;

public class PlataformaTeia : MonoBehaviour 
{
	public static PlataformaTeia instance;

	public bool segura = false;

	float tempo;
	
	void Awake()
	{
		instance = this;	
	}
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{

		Debug.Log (segura);
		Debug.Log (tempo);
		if ((segura) && (tempo <= Time.time)) 
		{
			segura = false;
		}
	}

	void OnCollisionEnter2D(Collision2D collision) 
	{
		if (collision.gameObject.tag == "Player") 
		{
			segura = true;
			tempo = Random.Range(1, 2) + Time.time;
		}
	}
}