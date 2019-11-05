using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveByTouch : MonoBehaviour
{

    [SerializeField] public float xMin;
    [SerializeField] public float xMax;

    Vector3 FirstPoint;
    Vector3 SecondPoint;
    float xAngle;
    float yAngle;
    float xAngleTemp;
    float yAngleTemp;

    void Start()
    {
        xAngle = 0;
        yAngle = 56.3f;
        this.transform.rotation = Quaternion.Euler(yAngle, xAngle, 0);
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                FirstPoint = Input.GetTouch(0).position;
                xAngleTemp = xAngle;
                yAngleTemp = yAngle;
                //Debug.Log("TOUCHED");
            }
            if (Input.GetTouch(0).phase == TouchPhase.Moved)
            {
                SecondPoint = Input.GetTouch(0).position;
                xAngle = xAngleTemp + (SecondPoint.x - FirstPoint.x) * 180 / Screen.width;
                yAngle = yAngleTemp + (SecondPoint.y - FirstPoint.y) * 90 / Screen.height;
                this.transform.rotation = Quaternion.Euler(Mathf.Clamp(yAngle, xMin, xMax), xAngle, 0.0f);
                
            }
        }

    }
}
