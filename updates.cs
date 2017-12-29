using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class updates : MonoBehaviour {

	void Update () {
        Debug.Log("Executando a Update");
	}

    void LateUpdate()
    {
        Debug.Log("Executando a Late UPDATE");
    }

}
