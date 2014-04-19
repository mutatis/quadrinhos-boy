using UnityEngine;
using System.Collections;

public class Frase3 : MonoBehaviour {

	void Start () {
		
	}

	void Update () {
		if (Input.GetMouseButtonDown(0)){
			Application.LoadLevel ("4Frase");
		}
	}
}
