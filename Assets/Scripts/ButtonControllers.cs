using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonControllers : MonoBehaviour {
	

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void StartButton(){
		SceneManager.LoadScene ("Scene1");
	}
	public void Instructions(){
		SceneManager.LoadScene ("Instructions");
	}
}