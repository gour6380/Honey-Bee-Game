using UnityEngine;
using System.Collections;

public class birdmove : MonoBehaviour {

	float x,y;
	Vector3 dir;
	public LayerMask top,left,right,bottom;
	private Collider2D mycol;
	public bool touched;
	public float[][] hitpos;
	// Use this for initialization
	void Start () {
		//x=Random.Range (-2,2);
		//y=Random.Range (-4,4);
		mycol = GetComponent<Collider2D>();
		dir= new Vector3(2,4,0);
		//Debug.Log (dir);
	}
	
	// Update is called once per frame
	void Update () {
	
		//x=Random.Range (-2,2);
		//y=Random.Range (-4,4);



		transform.Translate(dir*Time.deltaTime,Space.World);

		if(Physics2D.IsTouchingLayers (mycol,top)){
			dir=new Vector3(-2,-2,0);
			//Debug.Log ("top");
			transform.rotation= Quaternion.Euler(0,180.0f,0.0f);
		}
		else if(Physics2D.IsTouchingLayers (mycol,left)){
			dir=new Vector3(2,1,0);
			///Debug.Log("left");
			transform.rotation= Quaternion.Euler(0,0.0f,0.0f);

		}
		else if(Physics2D.IsTouchingLayers (mycol,right)){
			dir=new Vector3(-2,-2,0);
			///Debug.Log("right");
			transform.rotation= Quaternion.Euler(0,180.0f,0.0f);
			
		}
		else if(Physics2D.IsTouchingLayers (mycol,bottom)){
			dir=new Vector3(1,4,0);
			//Debug.Log("bot");
			transform.rotation= Quaternion.Euler(0,0.0f,0.0f);
			
		}


		/*
		if (transform.position.x >= 2 || transform.position.x <= -2) {
			transform.position=new Vector3(2.0f,transform.position.y,transform.position.z);
		}
		if (transform.position.y >= 4 || transform.position.y <= -4) {
			//transform.position.y=4.0f;
		}


		/*x = Mathf.Clamp(transform.position.x, -2,2);

		y = Mathf.Clamp(transform.position.y,-4,4);*/


	}
}
