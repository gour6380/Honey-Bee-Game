using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class homeAnimationController : MonoBehaviour {

	bool check=false;
	private Animator HeadingAnim, TapToPlayAnim;
	public GameObject TapToPlayButton, Heading ;
	private List<Animator> animlist;
	public GameObject[] settingElements;

	void Start () {
		HeadingAnim=Heading.GetComponent<Animator>();
		TapToPlayAnim=TapToPlayButton.GetComponent<Animator>();
		animlist = new List<Animator>();
		for(int i=0; i<settingElements.Length; i++)
		{
				animlist.Add(settingElements[i].GetComponent<Animator>());
		}
	
	}

			//setting button pressed
	public void SettingPressed(){
	
		if(!check)										//checks if the button is pressed even times or odd times
		{
			OpenSettings();
			check=true;								//true if button pressed once(odd times), calls the behaviour
		}
		else 
		{
			CloseSettings();
			check=false;								//false, if button pressed again, calls the back button
		}
	}


	void OpenSettings(){
		HeadingAnim.SetBool("escape", true);
		TapToPlayAnim.SetBool ("escape", true);

		foreach(Animator anim in animlist)
		{
			anim.SetBool ("escape", true);
		}

		

	}

	void CloseSettings(){
		HeadingAnim.SetBool("escape", false);
		TapToPlayAnim.SetBool ("escape", false);
		foreach(Animator anim in animlist)
		{
			anim.SetBool ("escape", false);
		}
		
	}
}
