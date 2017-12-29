using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotina : MonoBehaviour {

	public bool variavelDeTeste;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		StartCoroutine ("RotinaDeTeste");
	}

	IEnumerator RotinaDeTeste(){
		yield return new WaitForSeconds (2.0f);
		variavelDeTeste = !variavelDeTeste;
	}
}
