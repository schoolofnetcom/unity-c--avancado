using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class linearInter : MonoBehaviour {

	Light luz;
	void Start () {
		luz = GetComponent<Light> ();
	}


	void Update () {
		luz.intensity = Mathf.Lerp (luz.intensity, 10f, 0.00005f);
	}
}
