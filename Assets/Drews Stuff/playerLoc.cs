using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerLoc : MonoBehaviour
{
    
    public GameObject location_Mangager_object;
    private LocationManager locationManager;

    public GameObject LocObject;

    private float locationMultipler;
    private float locationOffsetX;
    private float locationOffsetZ;
    // Start is called before the first frame update
    void Start()
    {
        Input.location.Start();
        locationManager = location_Mangager_object.GetComponent<LocationManager>();
        locationMultipler = locationManager.locationMultipler;
        locationOffsetX = locationManager.locationOffsetX;
        locationOffsetZ = locationManager.locationOffsetZ;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.location.status == LocationServiceStatus.Running)
        {
            transform.position = new Vector3((Input.location.lastData.latitude+locationOffsetX)*locationMultipler, transform.position.y, (Input.location.lastData.longitude + locationOffsetZ) * locationMultipler);
        }
        else
        {
            Input.location.Start();
        }
    }
    
}
