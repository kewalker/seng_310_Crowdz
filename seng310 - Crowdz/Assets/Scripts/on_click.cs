using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class on_click : MonoBehaviour
{

    public GameObject map;
    public get_ray master_ray_script;
    public RaycastHit hit;

    public GameObject details;
    public GameObject mini_bar;
    public GameObject other_mini_bar;
    public string button;

    public GameObject pin_turn_on;
    public GameObject clock_1;
    public GameObject clock_2;

    public GameObject turn_off;
    public GameObject turn_off2;

    public Ray master_ray;


    // Use this for initialization
    void Start()
    {
        master_ray_script = map.GetComponent<get_ray>();
        master_ray = master_ray_script.master_ray;
        hit = master_ray_script.hit;
    }

    // Update is called once per frame
    void Update()
    {
        //if (Time.frameCount % 2 == 0) { 
        //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //master_ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //RaycastHit hit;

        master_ray = master_ray_script.master_ray;
        hit = master_ray_script.hit;


        if (Physics.Raycast(master_ray, out hit))
            {

            if (EventSystem.current.IsPointerOverGameObject())
            {
                print("hmm");
                //EventSystem.current.
            }

            else if (Input.GetButtonDown("Fire1") && hit.collider.tag == button)
            {

                mini_bar.gameObject.SetActive(true);

                if (pin_turn_on != null )
                {
                    pin_turn_on.gameObject.SetActive(true);
                }
                

                if (other_mini_bar != null)
                {
                    other_mini_bar.gameObject.SetActive(false);
                }

                if (turn_off != null)
                {
                  //  print("test_1");
                    turn_off.gameObject.SetActive(false);
                }
                if (turn_off2 != null)
                {
                   // print("test_2");
                    turn_off2.gameObject.SetActive(false);
                }
                if (turn_off != null)
                {
                    turn_off.gameObject.SetActive(true);
                }
            }

            else if (Input.GetButtonDown("Fire1") && hit.collider.tag == "map")
            {

                //turn_off.gameObject.SetActive(false);
                //turn_off2.gameObject.SetActive(false);
               // print("HELLO? from " + button);
                if (pin_turn_on != null)
                {
                    pin_turn_on.gameObject.SetActive(false);
                }

                if (details != null )
                {
                    details.gameObject.SetActive(false);
                }
                
                mini_bar.gameObject.SetActive(false);

                if (clock_1 != null)
                {
                   // print("clock_1");
                    clock_1.gameObject.SetActive(false);
                }

                if (clock_2 != null) {
                   // print("clock_2");
                    clock_2.gameObject.SetActive(false);
                }

                if (turn_off != null)
                    {
                       // print("test_1");
                        turn_off.gameObject.SetActive(false);
                    }
                    if (turn_off2 != null)
                    {
                        //print("test_2");
                        turn_off2.gameObject.SetActive(false);
                    }

                }
            }

       // }
    }
}
