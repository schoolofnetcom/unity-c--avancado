using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testeEnums : MonoBehaviour {

	public enum Luminosidade{baixo, medio, alto};
	public Luminosidade nivelDeIntensidade;
	Light luz;
	// Use this for initialization
	void Start () {

		luz = GetComponent<Light> ();

		if (nivelDeIntensidade == Luminosidade.baixo) {
			luz.intensity = 0.2f;
		} else if (nivelDeIntensidade == Luminosidade.medio) {
			luz.intensity = 0.7f;
		} else {
			luz.intensity = 1.2f;
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
