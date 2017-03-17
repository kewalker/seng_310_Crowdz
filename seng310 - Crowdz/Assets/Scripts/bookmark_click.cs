using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class bookmark_click : MonoBehaviour
{
    //public GameObject map;

    public GameObject fairways_button;
    public GameObject mcdons_button;

    public Vector3 mcdons_previous_position;

    //public GameObject bookmark;
    public Image bookmark_sprite;

    public GameObject search_suggestions;
    public GameObject map;
    public Vector3 set_map;
    public GameObject search_bar;
    public GameObject pin;
    public GameObject pin_2;

    

   // public GameObject search_suggestions;
    public GameObject bookmarks;

    public GameObject bar_1;
    public GameObject bar_2;

    public GameObject details;
    public GameObject details_2;
    public GameObject mini_bar;
    public string button;

    // Use this for initialization
    void Start()
    {
       /* mcdons_previous_position = mcdons_button.transform.position;

        if (bookmark_sprite.sprite.name == "no_bookmarks")
        {
            print("no bookmarks");
            mcdons_button.transform.position = mcdons_previous_position;
            fairways_button.gameObject.SetActive(false);
            mcdons_button.gameObject.SetActive(false);
            
        }

        else if (bookmark_sprite.sprite.name == "only_mcdonalds_bookmark")
        {
            print("found out its only dons");
            mcdons_button.transform.position = fairways_button.transform.position;
            fairways_button.SetActive(false);
            mcdons_button.SetActive(true);
            
        }

        else if (bookmark_sprite.sprite.name == "one_bookmark 1")
        {
            print("found out its only fairways");
            mcdons_button.transform.position = mcdons_previous_position;
            mcdons_button.gameObject.SetActive(false);
            fairways_button.gameObject.SetActive(true);
           
        }

        else if (bookmark_sprite.sprite.name == "two_bookmark 1")
        {
            print("both bookmarks");
            mcdons_button.transform.position = mcdons_previous_position;
            fairways_button.gameObject.SetActive(true);
            mcdons_button.gameObject.SetActive(true);
        }*/

    }

    // Update is called once per frame
    void Update()
    {
        /*print("button: " + mcdons_button);
        //print(bookmark_sprite.sprite.name);

        if (bookmark_sprite.sprite.name == "no_bookmarks")
        {
            mcdons_button.transform.position = mcdons_previous_position;
            mcdons_button.gameObject.SetActive(false);
            fairways_button.gameObject.SetActive(false);
        }

        else if (bookmark_sprite.sprite.name == "only_mcdonalds_bookmark")
        {
            mcdons_button.transform.position = fairways_button.transform.position;
            fairways_button.SetActive(false);
            mcdons_button.SetActive(true);
            print("found out its only dons");
        }

        else if (bookmark_sprite.sprite.name == "one_bookmark 1")
        {
            mcdons_button.transform.position = mcdons_previous_position;
            fairways_button.gameObject.SetActive(true);
            mcdons_button.gameObject.SetActive(false);
        }

        else if (bookmark_sprite.sprite.name == "two_bookmark 1")
        {
            mcdons_button.transform.position = mcdons_previous_position;
            fairways_button.gameObject.SetActive(true);
            mcdons_button.gameObject.SetActive(true);
        }
        //if (mcdons_button.)
        /*if (this.tag == "mc_bookmark_button")
        {
            print("hello from dons bookmarks");
        }*/
        
       // print("oh ya!");
        //Vector3 temp = set_map;
        //map.gameObject.SetActive(true);
        bar_1.gameObject.SetActive(false);
        bar_2.gameObject.SetActive(false);
        map.transform.position = set_map;
        map.gameObject.SetActive(true);
        mini_bar.gameObject.SetActive(true);
        pin.gameObject.SetActive(true);
        details.gameObject.SetActive(false);
        details_2.gameObject.SetActive(false);
        search_bar.gameObject.SetActive(false);
        pin_2.gameObject.SetActive(false);
        
        search_suggestions.gameObject.SetActive(false);
        bookmarks.gameObject.SetActive(false);
        this.gameObject.SetActive(false);
    }
}
