using UnityEngine;
using System.Collections;

public class Frase1 : MonoBehaviour {

	void Start () {
		
	}

	void Update () {
		if (Input.GetMouseButtonDown(0)){
			Application.LoadLevel ("2Frase");
		}
	}
}
