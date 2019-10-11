using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clicked : MonoBehaviour
{

    public GameObject camera;
    public GameObject sign;
    public float movespeed = 35.0f;
    //you need to say how far from the object the camera will stop
    public float minimumDistanceFromTarget = 5f;
    private bool movingtowardstarget = false;
    public bool zoomed;
    // Start is called before the first frame update
    void Start()
    {
        sign.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        GrabObject(camera);
    }

    private void OnMouseDown()
    {
        if (!zoomed)
        {
            zoomed = true;
            movingtowardstarget = true;
            sign.SetActive(true);
        }
    }
    
    public void GrabObject(GameObject target)
    {
        if(Vector3.Distance(transform.position, target.transform.position) > minimumDistanceFromTarget && movingtowardstarget) //we move only if we are further than the minimum distance
        {
            target.transform.position = Vector3.MoveTowards(target.transform.position, transform.position, movespeed * Time.deltaTime);
            target.transform.LookAt(transform.position);
        } else  //otherwise, we stop moving
        {
            movingtowardstarget = false;
        }
       
    }
}
