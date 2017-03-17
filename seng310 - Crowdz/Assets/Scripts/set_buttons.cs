using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class set_buttons : MonoBehaviour {

    public Image bookmark_sprite;
    public GameObject fairways_button;
    public GameObject mcdons_button;
    public Vector3 mcdons_previous_position;
    public Vector3 fairways_previous_position;

    // Use this for initialization
    void Start () {
        mcdons_previous_position = mcdons_button.transform.position;
        fairways_previous_position = fairways_button.transform.position;

        if (bookmark_sprite.sprite.name == "no_bookmarks")
        {
            //print("no bookmarks");
            mcdons_button.transform.position = mcdons_previous_position;
            fairways_button.gameObject.SetActive(false);
            mcdons_button.gameObject.SetActive(false);

        }

        else if (bookmark_sprite.sprite.name == "only_mcdonalds_bookmark")
        {
            //print("found out its only dons");
            mcdons_button.transform.position = fairways_button.transform.position;
            fairways_button.SetActive(false);
            mcdons_button.SetActive(true);

        }

        else if (bookmark_sprite.sprite.name == "one_bookmark 1")
        {
            //print("found out its only fairways");
            mcdons_button.transform.position = mcdons_previous_position;
            mcdons_button.gameObject.SetActive(false);
            fairways_button.gameObject.SetActive(true);

        }

        else if (bookmark_sprite.sprite.name == "two_bookmark 1")
        {
            //print("both bookmarks");
            mcdons_button.transform.position = mcdons_previous_position;
            fairways_button.gameObject.SetActive(true);
            mcdons_button.gameObject.SetActive(true);
        }


        //for the search result buttons
        if (bookmark_sprite.sprite.name == "search_results_no_stars 1")
        {
            //print("0");
            mcdons_button.transform.position = mcdons_previous_position;
            fairways_button.transform.position = fairways_previous_position;
            //fairways_button.gameObject.SetActive(true);
            //mcdons_button.gameObject.SetActive(true);

        }

        else if (bookmark_sprite.sprite.name == "fairways_star_search")
        {
            //print("1");
            mcdons_button.transform.position = mcdons_previous_position;
            fairways_button.transform.position = fairways_previous_position;
            //mcdons_button.transform.position = fairways_button.transform.position;
            //fairways_button.SetActive(false);
            //mcdons_button.SetActive(true);

        }

        else if (bookmark_sprite.sprite.name == "mcdons_star_search")
        {
            //print("2");
            mcdons_button.transform.position = fairways_previous_position;
            fairways_button.transform.position = mcdons_previous_position;
            //mcdons_button.transform.position = mcdons_previous_position;
            //mcdons_button.gameObject.SetActive(false);
            //fairways_button.gameObject.SetActive(true);

        }

        else if (bookmark_sprite.sprite.name == "search_results_two_stars")
        {
           // print("3");
            mcdons_button.transform.position = mcdons_previous_position;
            fairways_button.transform.position = fairways_previous_position;
        }





    }
	
	// Update is called once per frame
	void Update () {
        if (bookmark_sprite.sprite.name == "no_bookmarks")
        {
           // print("no bookmarks");
            mcdons_button.transform.position = mcdons_previous_position;
            fairways_button.gameObject.SetActive(false);
            mcdons_button.gameObject.SetActive(false);

        }

        else if (bookmark_sprite.sprite.name == "only_mcdonalds_bookmark")
        {
           // print("found out its only dons");
            mcdons_button.transform.position = fairways_button.transform.position;
            fairways_button.SetActive(false);
            mcdons_button.SetActive(true);

        }

        else if (bookmark_sprite.sprite.name == "one_bookmark 1")
        {
            //print("found out its only fairways");
            mcdons_button.transform.position = mcdons_previous_position;
            mcdons_button.gameObject.SetActive(false);
            fairways_button.gameObject.SetActive(true);

        }

        else if (bookmark_sprite.sprite.name == "two_bookmark 1")
        {
           // print("both bookmarks");
            mcdons_button.transform.position = mcdons_previous_position;
            fairways_button.gameObject.SetActive(true);
            mcdons_button.gameObject.SetActive(true);
        }

        //for the search result buttons
        if (bookmark_sprite.sprite.name == "search_results_no_stars 1")
        {
           // print("0");
            mcdons_button.transform.position = mcdons_previous_position;
            fairways_button.transform.position = fairways_previous_position;
            //fairways_button.gameObject.SetActive(true);
            //mcdons_button.gameObject.SetActive(true);

        }

        else if (bookmark_sprite.sprite.name == "fairways_star_search")
        {
            //print("1");
            mcdons_button.transform.position = mcdons_previous_position;
            fairways_button.transform.position = fairways_previous_position;
            //mcdons_button.transform.position = fairways_button.transform.position;
            //fairways_button.SetActive(false);
            //mcdons_button.SetActive(true);

        }

        else if (bookmark_sprite.sprite.name == "mcdons_star_search")
        {
           // print("2");
            mcdons_button.transform.position = fairways_previous_position;
            fairways_button.transform.position = mcdons_previous_position;
            //mcdons_button.transform.position = mcdons_previous_position;
            //mcdons_button.gameObject.SetActive(false);
            //fairways_button.gameObject.SetActive(true);

        }

        else if (bookmark_sprite.sprite.name == "search_results_two_stars")
        {
           // print("3");
            mcdons_button.transform.position = mcdons_previous_position;
            fairways_button.transform.position = fairways_previous_position;
        }
    }
}
