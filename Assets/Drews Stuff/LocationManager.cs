using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

[System.Serializable]
public class LocationManager : MonoBehaviour
{
    
    public GameObject[] gameObjects;
    [FormerlySerializedAs("locationModifer")] public float locationMultipler;

    public float locationOffsetX;
    public float locationOffsetZ;
    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject locObjects in gameObjects)
        {
            locObjects.transform.position = new Vector3((transform.position.x + locationOffsetX)* locationMultipler, transform.position.y, (transform.position.z+ locationOffsetZ)* locationMultipler);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void backButtonPressed(GameObject parentMenu) //hide the menu
    {
        parentMenu.SetActive(false);
    }
}
