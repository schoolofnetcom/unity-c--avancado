using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rbScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
		if(Input.GetKeyDown(KeyCode.G)){
			gameObject.AddComponent<Rigidbody> ();
		}

	}
}
