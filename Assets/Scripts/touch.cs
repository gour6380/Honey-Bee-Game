using UnityEngine;
using System.Collections;

public class touch : MonoBehaviour {

	// Use this for initialization
	Vector3 realWorldPos;
	Vector2 fingerPos;
	Vector3 pos;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.touchCount>0 )
		{
		Touch t =  Input.GetTouch(0);
		fingerPos=t.position;
		Debug.Log("abc"+fingerPos);
		pos = fingerPos;
		pos.z = 8;
		realWorldPos = Camera.main.ScreenToWorldPoint(pos);
		transform.position=realWorldPos;
		}

	
	}
}
