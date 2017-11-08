using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LunchboxController : MonoBehaviour {

    public string itemName;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider lunchItem) {

        itemName = lunchItem.name;
		Debug.Log (itemName);
		Destroy (lunchItem);

    }
}
