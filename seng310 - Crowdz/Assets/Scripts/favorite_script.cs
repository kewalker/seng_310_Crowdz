using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class favorite_script : MonoBehaviour {

    public GameObject details;
    //public GameObject search_suggestions;

    public GameObject cube_with_flip;
    public GameObject cube_with_flip_other;

    

    public string button;

    public Image img;
    public Sprite[] sprite;
    public Material [] search_sprite;

    public Image bookmark;
    public Sprite[] bookmarks;

    public Image search_suggestions;
    public Sprite[] search_suggestions_sprites;

    public Image mini_bar;
    public Sprite[] mini_bar_sprites;

    public Material[] mat;
    public int flip;
    public int other_flip;

    //public Sprite temp;

	// Use this for initialization
	void Start () {
        //flip = 0;
        details.GetComponent<Renderer>().material = mat[flip];
        //search_suggestions.GetComponent<Renderer>().material = search_sprite[flip];
        //img.sprite = sprite[flip];
        mini_bar.sprite = mini_bar_sprites[flip];
        //flip = 1 - flip;
	}
	
	// Update is called once per frame
	void Update () {
        other_flip = cube_with_flip_other.GetComponent<favorite_script>().flip;
        //print("other flip: " + other_flip);

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {

            

            //print("whoohoooh");
            if (Input.GetButtonDown("Fire1") && hit.collider.tag == button)
            {


                flip = 1 - flip;

                details.GetComponent<Renderer>().material = mat[flip];
                //search_suggestions.GetComponent<Renderer>().material = search_sprite[flip];
                //img.sprite = sprite[flip];
                mini_bar.sprite = mini_bar_sprites[flip];

                if (flip == 0 && other_flip == 0)
                {
                    //both off
                    bookmark.sprite = bookmarks[0];
                    search_suggestions.sprite = search_suggestions_sprites[0];
                }

                else if (flip == 0 && other_flip == 1)
                {
                    //only mcdons from mcdons
                    if (hit.collider.tag == "favorite_2")
                    {
                        //print("favor_1");
                        bookmark.sprite = bookmarks[2];
                        search_suggestions.sprite = search_suggestions_sprites[2];
                    } else if (hit.collider.tag == "favorite")
                    {
                       // print("favor_2");
                        bookmark.sprite = bookmarks[1];
                        search_suggestions.sprite = search_suggestions_sprites[1];
                    }
                }
                else if (flip == 1 && other_flip == 0)
                {
                    //just other one on
                    //only mcdons from mcdons
                    if (hit.collider.tag == "favorite")
                    {
                        //print("favor_3");
                        bookmark.sprite = bookmarks[2];
                        search_suggestions.sprite = search_suggestions_sprites[2];
                    }
                    else if (hit.collider.tag == "favorite_2")
                    {
                       // print("favor_4");
                        bookmark.sprite = bookmarks[1];
                        search_suggestions.sprite = search_suggestions_sprites[1];
                    }
                }

                if (flip == 1 && other_flip == 1)
                {
                    //print("here tooooo");
                    bookmark.sprite = bookmarks[3];
                    search_suggestions.sprite = search_suggestions_sprites[3];
                }
                /*else {
                    //both on
                    print("all of em!");
                    bookmark.sprite = bookmarks[3];
                }*/





                //img.sprite = temp;
                //img.sprite

            }

            /*else if (Input.GetButtonDown("Fire1") && hit.collider.tag == "map")
            {
                details.gameObject.SetActive(false);
            }*/

        }
    }
}
