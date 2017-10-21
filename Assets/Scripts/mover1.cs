using UnityEngine;
using System.Collections;

public class mover1 : MonoBehaviour {

	float x,y;
	Vector3 dir;
	public LayerMask top,left,right,bottom;
	private Collider2D mycol;
	public float[][] hitpos;
	// Use this for initialization
	void Start () {

		mycol = GetComponent<Collider2D>();
		dir= new Vector3(2,2,0);

	}
	
	// Update is called once per frame
	void Update () {
		

		transform.Translate(dir*Time.deltaTime,Space.World);
		
		if(Physics2D.IsTouchingLayers (mycol,top)){
			dir=new Vector3(-1,-1,0);
		//	Debug.Log ("top");
			transform.rotation= Quaternion.Euler(0,180.0f,0.0f);
		}
		else if(Physics2D.IsTouchingLayers (mycol,left)){
			dir=new Vector3(2,-4,0);
		//	Debug.Log("left");
			transform.rotation= Quaternion.Euler(0,0.0f,0.0f);
			
		}
		else if(Physics2D.IsTouchingLayers (mycol,right)){
			dir=new Vector3(-2,1,0);
			//Debug.Log("right");
			transform.rotation= Quaternion.Euler(0,180.0f,0.0f);
			
		}
		else if(Physics2D.IsTouchingLayers (mycol,bottom)){
			dir=new Vector3(1,4,0);
			//Debug.Log("bot");
			transform.rotation= Quaternion.Euler(0,0.0f,0.0f);
			
		}
	}
}
