using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour 
{
	
	public int n_do_ponto;
	int score_game;
	
	void Start () {
		
	}
	
	void Update () {

		score_game = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerSettings>().ponto;

		if (score_game >= 1 && n_do_ponto == 1) {
			renderer.enabled = true;
		}
		if (score_game >= 2 && n_do_ponto == 2) {
			renderer.enabled = true;
		}
		if (score_game >= 3 && n_do_ponto == 3) {
			renderer.enabled = true;
		}
		if (score_game >= 4 && n_do_ponto == 4) {
			renderer.enabled = true;
		}
		if (score_game >= 5 && n_do_ponto == 5) {
			renderer.enabled = true;
		}
	}
}