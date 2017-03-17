using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class get_ray : MonoBehaviour
{

    public Ray master_ray;
    public RaycastHit hit;

    //RaycastHit hit;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        master_ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        //if (Physics.Raycast(master_ray, out hit))
        //{
            //print(hit.collider.tag);
        //}

    }
}
