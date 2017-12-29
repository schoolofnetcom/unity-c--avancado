using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ligaLuz : MonoBehaviour {
    
	Light luz;
	// Use this for initialization
	void Start () {
		luz = GetComponent<Light> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.A)){
			luz.enabled = !luz.enabled;
		}
	}
}
