using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class pot : MonoBehaviour {
	int potno;
	public Text pots;
	// Use this for initialization
	void Start () {
		potno=0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter2D(Collision2D coll){
		if(coll.gameObject.tag=="Player"){
			potno++;
			pots.text="x"+potno;
			gameObject.SetActive(false);
		}
	}
}
