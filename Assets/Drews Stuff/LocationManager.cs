using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

[System.Serializable]
public class LocationManager : MonoBehaviour
{
    
    public GameObject[] gameObjects;
    private SphereCollider[] sphereColliders;
    [FormerlySerializedAs("locationModifer")] public float locationMultipler;
    public float colliderRadius;

    public float locationOffsetX;
    public float locationOffsetZ;
    // Start is called before the first frame update
    void Start()
    {
        //foreach (GameObject locObject in gameObjects)
        //{
        //    locObject.transform.position = new Vector3((locObject.transform.position.x + locationOffsetX)* locationMultipler, locObject.transform.position.y, (locObject.transform.position.z+ locationOffsetZ)* locationMultipler);
        //}
        for (int i = 0; i < gameObjects.Length; i++)
        {
            gameObjects[i].transform.position = new Vector3((gameObjects[i].transform.position.x + locationOffsetX) * locationMultipler, gameObjects[i].transform.position.y, (gameObjects[i].transform.position.z + locationOffsetZ) * locationMultipler);
            sphereColliders[i] = gameObjects[i].GetComponent<SphereCollider>();
            sphereColliders[i].radius = colliderRadius;
            Gizmos.DrawWireSphere(gameObjects[i].transform.position, colliderRadius);
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
