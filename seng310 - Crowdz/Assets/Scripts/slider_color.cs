using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class slider_color : MonoBehaviour {

    public Slider slider;
    public Image[] images;
   // public Image image;

	// Use this for initialization
	void Start () {
        slider = gameObject.GetComponent<Slider>();
       // image = gameObject.GetComponentInChildren<Image>();
	}
	
	// Update is called once per frame
	void Update () {
		if (slider.value == 0)
        {
            print("0");
            //ColorBlock cb = slider.colors;
            //cb.normalColor = Color.white;
            //slider.colors = cb;

            images = gameObject.GetComponentsInChildren<Image>(); //= Color.white;
            foreach (Image image in images)
            {
                image.color = Color.white;
            }

            //slider.colors.normalColor = Color.white;
            //slider.GetComponent<>
            //slider.GetComponent<Renderer>().material.color = Color.white; // renderer.material.color = Color.white; // colors.normalColor = Color.white;
            //gameObject.GetComponentInChildren<Image>().color = Color.white;
        } else
        {
            print("1");
            //ColorBlock cb = slider.colors;
            //cb.normalColor = Color.cyan;
            //slider.colors = cb;

            images = gameObject.GetComponentsInChildren<Image>(); //= Color.white;
            foreach (Image image in images)
            {
                image.color = Color.cyan;
            }


            //gameObject.GetComponentInChildren<Image>().color = Color.cyan;

            //slider.GetComponent<Renderer>().material.color = Color.cyan;
            //gameObject.GetComponentInChildren<Image>().color = Color.cyan;
        }
	}
}
