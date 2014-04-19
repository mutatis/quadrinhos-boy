using UnityEngine;
using System.Collections;

public class Apresentacao : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//transform.Translate (0, 0, 0);

		if(transform.position.x <= 22.63031){
			transform.Translate (0.009f, 0, 0);
		}
		if(transform.position.x >= 22.63031){
			transform.Translate (0, 0, 0);
		}
	}
}
