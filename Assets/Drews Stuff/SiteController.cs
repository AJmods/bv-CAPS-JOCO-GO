﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SiteController : MonoBehaviour
{
    public GameObject menu;
    //public GameObject player;
    //private GameObject sign;
    // Start is called before the first frame update
    void Start()
    {
        menu.SetActive(false);
        //sign = transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        //sign.transform.LookAt(player.transform.position);
    }

    private void OnMouseDown()
    {
        menu.SetActive(true); //activate or deactivate the menu
    }

    private void OnTriggerEnter(Collider other)
    {
        
    }
}
