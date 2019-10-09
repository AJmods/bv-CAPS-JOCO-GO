using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class textStuff : MonoBehaviour
{
    public TextMeshProUGUI lat;

    public TextMeshProUGUI lon;
    // Start is called before the first frame update
    void Start()
    {
        Input.location.Start();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.location.isEnabledByUser)
        {
            lat.text = "Latitude: " + Input.location.lastData.latitude;
            lon.text = "Longitude " + Input.location.lastData.longitude;
        }
    }
}
