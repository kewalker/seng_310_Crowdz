using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turn_on : MonoBehaviour {

    public GameObject element;

	// Use this for initialization
	void Start () {
        element.gameObject.SetActive(true);
        this.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
        element.gameObject.SetActive(true);
        //}

        this.enabled = false;
    }
}
