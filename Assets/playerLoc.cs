using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerLoc : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Input.location.Start();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Input.location.lastData.latitude, transform.position.y, Input.location.lastData.longitude);
    }
}
