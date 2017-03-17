using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class on_click_with_master_ray : MonoBehaviour
{

    public on_click click_script;

    public GameObject details;
    public GameObject mini_bar;
    public GameObject other_mini_bar;
    public string button;

    public GameObject pin_turn_on;

    public GameObject turn_off;
    public GameObject turn_off2;

    public Ray master_ray;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //if (Time.frameCount % 2 == 0) { 
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        master_ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {

            if (EventSystem.current.IsPointerOverGameObject())
            { //IsPointerOverEventSystemObject())
              //Debug.Log("left-click over a GUI element!");
              //touched = false;
                if (Input.GetButtonDown("Fire1"))
                {
                    details.gameObject.SetActive(false);
                }
            }

            else if (Input.GetButtonDown("Fire1") && hit.collider.tag == button)
            {

                mini_bar.gameObject.SetActive(true);
                pin_turn_on.gameObject.SetActive(true);

                if (other_mini_bar != null)
                {
                    other_mini_bar.gameObject.SetActive(false);
                }

                if (turn_off != null)
                {
                    print("test_1");
                    turn_off.gameObject.SetActive(false);
                }
                if (turn_off2 != null)
                {
                    print("test_2");
                    turn_off2.gameObject.SetActive(false);
                }
                turn_off.gameObject.SetActive(true);
            }

            else if (Input.GetButtonDown("Fire1") && hit.collider.tag == "map")
            {

                //turn_off.gameObject.SetActive(false);
                //turn_off2.gameObject.SetActive(false);
                if (pin_turn_on != null)
                {
                    pin_turn_on.gameObject.SetActive(false);
                }

                details.gameObject.SetActive(false);
                mini_bar.gameObject.SetActive(false);
            }
        }

        // }
    }
}
