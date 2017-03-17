using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ui_text_field : MonoBehaviour {

    public GameObject search_items;
    public Text text_field;

    public bool used;

	// Use this for initialization
	void Start () {
		used = false;
	}
	
	// Update is called once per frame
	void Update () {
        //print(text_field.text.ToString());

        if (text_field.text.ToString() != "")
        {
            search_items.gameObject.SetActive(true);
            used = true;
        }


        else
        {
            /*search_items.gameObject.SetActive(false);
            //this.gameObject.SetActive(false);
            if (used == true)
            {
                this.gameObject.SetActive(false);
                used = false;
            }*/
        }

        
	}
}
