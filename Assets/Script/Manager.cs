using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour 
{

	public GameObject inimigo;
	float tempo = 3;
	float posicaoY;
	float posicaoX;
	int pos_x;

	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		posicaoY = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerSettings>().posicaoY;
		posicaoX = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerSettings>().posicaoAtual;
	
		if (tempo <= Time.time)
		{			
			pos_x = Random.Range(-10, 10);		
			Instantiate (inimigo, new Vector3 ((posicaoX + pos_x), (posicaoY + 12), 0), Quaternion.identity);
			tempo = Random.Range(7, 12) + Time.time;		
		}
	}
}
