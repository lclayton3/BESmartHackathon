using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour{
	public float speed;
	private float height;
void Start (){
		speed = 5f;
}
	//Input.GetAxis("Vertictal")
void Update (){
		
		height = Terrain.activeTerrain.SampleHeight (transform.position) + 1.28f;
		transform.Translate (speed*Input.GetAxis("Horizontal")*Time.deltaTime, 0f,speed*Input.GetAxis("Vertical")*Time.deltaTime);
		//transform.position.y = 1.28f;
}
}