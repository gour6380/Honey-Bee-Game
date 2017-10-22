using UnityEngine;
using System.Collections;

public class death : MonoBehaviour {
	public GameObject text,player,button,box,lolipop;
	public LayerMask birds;
	private Collider2D mycol;
	public pot PotScript;
	public collectable LolipopScript;

	public int Potscore, LolipopScore, TotalScore;
	public int highscore;

	/*void OnCollisionEnter2D(Collision2D colll)
	{
		Debug.Log("death1111");
		if(colll.gameObject.tag=="Birds")
		{
			Debug.Log("death");
			text.SetActive (true);
			player.SetActive (false);
			button.SetActive (true);
		}
	}*/

	void Start () {
		
		mycol = GetComponent<Collider2D>();

		PotScript=GameObject.FindGameObjectWithTag("pot").GetComponent<pot>();
		LolipopScript=GameObject.FindGameObjectWithTag("lolipop").GetComponent<collectable>();
		highscore=PlayerPrefs.GetInt("highscore");

	}

	void Update(){
		if(Physics2D.IsTouchingLayers (mycol,birds)){
			Debug.Log("death");
			dead ();

		}
	}


	public void buttonclicked()
	{
		Application.LoadLevel(0);
	}

	void dead(){

		text.SetActive (true);
		box.SetActive (true);
		lolipop.SetActive (false);
		player.SetActive (false);
		button.SetActive (true);
		Score();
	}

	void Score(){

		Potscore=PotScript.potno;
		LolipopScore=LolipopScript.score;
		TotalScore=Potscore+LolipopScore;
		if(TotalScore>highscore)
			PlayerPrefs.SetInt("highscore",TotalScore);
		highscore=PlayerPrefs.GetInt("highscore");
		Debug.Log ("pot"+Potscore+"loli"+ LolipopScore+"total"+ TotalScore+"high"+highscore);
	}
}
