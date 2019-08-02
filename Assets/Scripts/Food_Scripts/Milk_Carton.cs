using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Milk_Carton : MonoBehaviour {
	public string itemName;
	public int i = 0;
	public Text itemList;
	public int selected = 0;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	void OnMouseDown() {
		gameObject.active = false;
		itemName = this.gameObject.name;
		selected = 1;

		gameObject.SetActive (false);


	}

}