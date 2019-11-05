using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class locationManager2 : MonoBehaviour
{

    public GameObject sitesParent;
    public GameObject menuParent;
    public List<GameObject> menus;
    public List<GameObject> sites;
    private siteController2[] siteController2s;

    private SphereCollider[] sphereColliders;
    public float locationMultipler;
    public float colliderRadius;

    public float locationOffsetX;
    public float locationOffsetZ;
    
    // Start is called before the first frame update
    void Start()
    {
        siteController2s = new siteController2[sitesParent.transform.childCount];
        sphereColliders = new SphereCollider[sitesParent.transform.childCount];
        for (int i = 0; i < sitesParent.transform.childCount; i++)
        {
            sites.Add(sitesParent.transform.GetChild(i).gameObject);
            menus.Add(menuParent.transform.GetChild(i).gameObject);
            Debug.Log(sites[i].gameObject.GetComponent<siteController2>());
            siteController2s[i] = (sites[i].GetComponent<siteController2>());
            siteController2s[i].menu = menus[i];
            siteController2s[i].menu.SetActive(false);
            sites[i].transform.position = new Vector3((sites[i].transform.position.x + locationOffsetX) * locationMultipler, sites[i].transform.position.y, (sites[i].transform.position.z + locationOffsetZ) * locationMultipler);
            sphereColliders[i] = (sites[i].GetComponent<SphereCollider>());
            sphereColliders[i].radius = colliderRadius;
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
