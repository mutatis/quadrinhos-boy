using UnityEngine;
using System.Collections;

public class GaiolaFechada : MonoBehaviour 
{
	//public int ia_god;
	int fechada_porta;
	
	// Use this for initialization
	void Start () {
		
	}
	
	void Update () {
		fechada_porta = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerSettings>().ponto;

		if (fechada_porta == 5){
			Destroy(gameObject);
		}
	}
}