using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerLoc : MonoBehaviour
{

    public GameObject location_Mangager_object;
    private LocationManager locationManager;
    // Start is called before the first frame update
    void Start()
    {
        Input.location.Start();
        locationManager = location_Mangager_object.GetComponent<LocationManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.location.status == LocationServiceStatus.Running)
        {
            transform.position = new Vector3(Input.location.lastData.latitude*locationManager.locationModifer, transform.position.y, Input.location.lastData.longitude * locationManager.locationModifer);
        }
        else
        {
            Input.location.Start();
        }
    }
}
