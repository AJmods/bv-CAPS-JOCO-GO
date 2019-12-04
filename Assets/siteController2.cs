using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class siteController2 : MonoBehaviour
{
    public GameObject locationManager2Object;
    private locationManager2 locationManager;

    public GameObject player;
    private playerLoc pLoc;

    public GameObject menu;
    // Start is called before the first frame update
    void Start()
    {
        locationManager = locationManager2Object.GetComponent<locationManager2>();
        pLoc = player.GetComponent<playerLoc>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began)) //if object hit
        {
            Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit raycastHit;
            if (Physics.Raycast(raycast, out raycastHit))
            {
                
            }
        }
    }
    private void OnMouseDown()
    {
        menu.SetActive(true); //activate or deactivate the menu

    }
    private void OnTriggerEnter(Collider other)
    {
        pLoc.LocObject = gameObject;
    }
}
