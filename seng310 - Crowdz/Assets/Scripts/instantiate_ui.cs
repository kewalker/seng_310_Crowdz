using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class instantiate_ui : MonoBehaviour {
    
    public GameObject gui;

	// Use this for initialization
	void Start () {
        //gui = FindObjectOfType<Button>();
        print("hello");
        Instantiate(gui, gameObject.transform.position, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
        print("hello from instantiate");
	}
}
