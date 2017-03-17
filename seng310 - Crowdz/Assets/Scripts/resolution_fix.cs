using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resolution_fix : MonoBehaviour {

    int timer = 2;

	// Use this for initialization
	void Start () {
        Screen.SetResolution(360, 640, false);
        StartCoroutine(wait_for_palette(timer));
    }
	
	// Update is called once per frame
	void Update () {
        
        Screen.SetResolution(360, 640, false);
    }

    //wait for game_manager to set up palette, then grab it
    IEnumerator wait_for_palette(float wait)
    {

        yield return new WaitForSeconds(wait);

        Destroy(this);

    }

}
