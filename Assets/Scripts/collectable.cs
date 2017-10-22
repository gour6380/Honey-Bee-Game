using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class collectable : MonoBehaviour {

	// Use this for initialization
	float x,y,x1,y1;
	public int score;
	public Text lolipops;
	public GameObject pot,bee,b1,b2,b3;
	void Start () {
		score=0;
	
	}
	
	// Update is called once per frame
	void Update () {


	}
	void OnCollisionEnter2D(Collision2D col){
		//Debug.Log ("collision");
		if(col.gameObject.tag=="Player"){

			x=Random.Range(-2.5f,2);
			y=Random.Range (-4.8f,4.5f);
			transform.position=new Vector3(x,y,-1);
			score++;
			bee.transform.localScale= new Vector3 (bee.transform.localScale.x+0.02f,bee.transform.localScale.y+0.02f,1);
			lolipops.text = ""+score;
			//Debug.Log (score);
			if(score%3==0){
				x1=Random.Range(-2.5f,2);
				y1=Random.Range (-4.8f,4.5f);
				pot.SetActive (true);
				pot.transform.position=new Vector3(x1,y1,-1);
			}
			else{
				pot.SetActive (false);
			}
			if (score==5)
				b1.SetActive (true);
			else if(score==8)
				b2.SetActive (true);
			else if(score==13)
				b3.SetActive (true);
		}

	}

}
