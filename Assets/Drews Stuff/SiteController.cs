using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SiteController : MonoBehaviour
{
    public GameObject menu;
    // Start is called before the first frame update
    void Start()
    {
        menu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        menu.SetActive(true); //activate or deactivate the menu
    }

    private void OnTriggerEnter(Collider other)
    {
        
    }
}
