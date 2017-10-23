using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testinganim : MonoBehaviour {
	bool check=false;
	public Animator HeadingAnim, TapToPlayAnim;
	public GameObject TapToPlay;
	// Use this for initialization
	void Start () {
		HeadingAnim=GetComponent<Animator>();
		TapToPlayAnim=TapToPlay.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	 
	public void pressed(){
		Debug.Log(check);
		if(!check)
		{
			HeadingAnim.SetBool("escape", true);
			TapToPlayAnim.SetBool ("escape", true);
			check=true;
		}
		else 
		{
			HeadingAnim.SetBool("escape", false);
			TapToPlayAnim.SetBool ("escape", false);
			check=false;
	}}
}
