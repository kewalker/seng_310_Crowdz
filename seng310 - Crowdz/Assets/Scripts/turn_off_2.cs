using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turn_off_2 : MonoBehaviour
{

    public GameObject element;

    // Use this for initialization
    void Start()
    {
        element.gameObject.SetActive(false);
        this.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        element.gameObject.SetActive(false);
        this.enabled = false;
    }
}
