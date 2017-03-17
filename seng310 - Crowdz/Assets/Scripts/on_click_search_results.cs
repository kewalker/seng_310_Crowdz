using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class on_click_search_results : MonoBehaviour
{

    public GameObject search_suggestions;
    public GameObject map;
    public Vector3 set_map;
    public GameObject search_bar;
    public GameObject pin;

    //public GameObject bookmarks;

    public GameObject details;
    public GameObject mini_bar;
    public string button;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
           
            if (EventSystem.current.IsPointerOverGameObject())
            { //IsPointerOverEventSystemObject())
                //Debug.Log("left-click over a GUI element!");
                //touched = false;
            }

            else if (Input.GetButtonDown("Fire1") && hit.collider.tag == button)
            {
                print("oh ya!");
                mini_bar.gameObject.SetActive(true);
                pin.gameObject.SetActive(true);
                details.gameObject.SetActive(false);
                search_bar.gameObject.SetActive(false);
                map.transform.position = set_map;
                search_suggestions.gameObject.SetActive(false);
            }

            else if (Input.GetButtonDown("Fire1") && hit.collider.tag == "map")
            {
                details.gameObject.SetActive(false);
                pin.gameObject.SetActive(false);
                mini_bar.gameObject.SetActive(false);
            }

        }
        //void OnCollision
    }
}
