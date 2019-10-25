﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocationManager : MonoBehaviour
{
    
    public GameObject[] gameObjects;
    public float locationModifer;
	public GameObject Camera;
    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject locObjects in gameObjects)
        {
            locObjects.transform.position = new Vector3(transform.position.x * locationModifer, transform.position.y, transform.position.z * locationModifer);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}