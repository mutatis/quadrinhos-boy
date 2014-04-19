#pragma strict

var texto =" vazio";

function Start () {

}

function Update () {
  
	for(var i:int =0; i < Input.touches.Length; i++){ // quantos toques voce tem ??

	var touch:Touch=Input.touches[i]; //o toque
	var ray = Camera.main.ScreenPointToRay (Input.GetTouch(i).position);
	var hit:RaycastHit =new RaycastHit ();

		 if(Physics.Raycast(ray,hit,1000)){
			  if(hit.collider.gameObject ==this.gameObject){
			   
				   switch (touch.phase) {
				   
				    case TouchPhase.Began: // se o toque começar
				    texto = "tocou no objeto"; 
				       break;
				    
				      case TouchPhase.Stationary: // se o toque começar
				        texto = "Esta segunrando o objeto"; 
				      break;
				   
				   }
			  }
		 }
	}
}

function OnGUI () {
	GUI.Label (Rect (200, 200, 600, 20), "objeto touch: " + texto); 
}