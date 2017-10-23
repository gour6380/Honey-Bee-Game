using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleButton : MonoBehaviour {
	private bool isclicked=false;
	public Sprite OnSprite;
	public Sprite OffSprite;
	Image img;
	// Use this for initialization
	void Start () {
		 img=gameObject.GetComponent<Image>();
		img.sprite=OnSprite;
	}
	

	public void ButtonPressed () {
		if (! isclicked) {									//first or odd times aka ON
			img.sprite=OffSprite;
			isclicked=true;
		}
		else {				//even times aka OFF
		
			img.sprite=OnSprite;
			isclicked=false;
		}
	}
}
