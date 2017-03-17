using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class map_manipulation : MonoBehaviour {

    public float speed;
    public int speed_max;
    private bool touched;

    private Vector3 start_touch;

    private Vector3 first_touch;
    private Vector3 next_touch;

    private EventSystem manager;

    // Use this for initialization
    void Start () {
            speed = 4;
            touched = false;
    }
	
	// Update is called once per frame
	void Update () {

        //print("ok");

        //check for touch
        if (Input.GetButtonDown("Fire1"))
        {
            //Debug.Log(Input.mousePosition);
            //print("ok2");
            start_touch = Input.mousePosition;
            touched = true;
        }

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            
            if (Input.GetButton("Fire1") && touched == true)
            {
                if (EventSystem.current.IsPointerOverGameObject())
                { //IsPointerOverEventSystemObject())
                    //Debug.Log("left-click over a GUI element!");
                    touched = false;
                }

                else {
                    //Debug.Log("just a left-click!");
                    if (hit.collider.tag == "map")
                    {
                        //print("mappy");
                        next_touch = Input.mousePosition;

                        Vector3 distance = next_touch - start_touch;

                        transform.position += distance * speed * Time.deltaTime;

                        start_touch = next_touch;
                    }
                }
                
            }
        }
            
       if (Input.GetButtonUp("Fire1"))
        {
            touched = false;
        }
       
        //left edge boundary
        if (transform.position.x < -36)
        {
            this.transform.position = new Vector3(-36f, transform.position.y, transform.position.z);
        }
        //right edge boundary
        if (transform.position.x > 35)
        {
            this.transform.position = new Vector3(35f, transform.position.y, transform.position.z);
        }
        //bottom screen boundary
        if (transform.position.y < -6)
        {
            this.transform.position = new Vector3(transform.position.x, -6f, transform.position.z);
        }
        if (transform.position.y > 6)
        {
            this.transform.position = new Vector3(transform.position.x, 6f, transform.position.z);
        }
    }

}

