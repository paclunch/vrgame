using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
	public Text counterText;
	public float seconds;
	public float startTime = 20.0f;
	public float count;

	// Use this for initialization
	void Start () {
		counterText = GetComponent<Text> () as Text;
	}

	// Update is called once per frame
	void Update () {
		seconds = (int)(Time.timeSinceLevelLoad % 60f);
		count = startTime - seconds;
		counterText.text = count.ToString ("00");
		}
		
}
