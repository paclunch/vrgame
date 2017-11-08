using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DisappearOnClick : MonoBehaviour {
	public string itemName;
	public int i = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseDown() {
		gameObject.active = false;
		Debug.Log (this.gameObject.name + " was packed");
		gameObject.SetActive (false);


	}

}
