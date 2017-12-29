using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pegaObj : MonoBehaviour {

	GameObject CAP;
	// Use this for initialization
	void Start () {
		CAP = GameObject.FindWithTag ("Cap");
		Destroy (CAP, 5f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
