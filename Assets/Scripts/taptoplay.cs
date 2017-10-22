using UnityEngine;
using System.Collections;

public class taptoplay : MonoBehaviour {
	protected  Animation anim;
	public GameObject taptoplaybutton;
	// Use this for initialization
	void Start () {
		anim=taptoplaybutton.GetComponent<Animation>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void tappaly(){
		Application.LoadLevel (1);
	}

	public void SettingPressed(){
		Debug.Log ("setting");
		anim.Play();
	}
}
