using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testinganim : MonoBehaviour {

	public Animation anim;
	// Use this for initialization
	void Start () {
		anim=GetComponent<Animation>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	 
	public void pressed(){
		anim.Play ();

	}
}
